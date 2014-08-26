// == PREAMBLE ================================================

// * Licensed under the Apache License, Version 2.0; see README
//   -- USE AT YOUR OWN RISK --

// == FILEDOC =================================================

/** @file CudaModule.h
  * @author JKM
  * @date 08/21/2014
  * @copyright Apache License, Version 2.0
  * @brief DOM for single CUDA file
**/

#ifndef rrGPU_CUDADOM_CudaModule_H
#define rrGPU_CUDADOM_CudaModule_H

// == MACROS ==================================================

#if !defined(__cplusplus)
#   error "You are including a .hpp in non-C++ code"
#endif

#if (__cplusplus < 201103L) && !defined(_MSC_VER)
#   error "This file requires C++11 support in order to compile"
#endif

// == INCLUDES ================================================

# include <gpu/bdom/Structures.hpp>

// == CODE ====================================================


namespace rr
{

namespace rrgpu
{

namespace dom
{

/**
 * @author JKM
 * @brief Variable initialization expressions
 */
class CudaVariableDeclarationExpression : public VariableDeclarationExpression {
public:
    /// Ctor
    CudaVariableDeclarationExpression(Variable* var, bool shared=false)
      : VariableDeclarationExpression(var), cuda_shared_(shared) {}

    /// Is this a shared memory declaration?
    bool isShared() const { return cuda_shared_; }
    /// Set whether this is a shared memory declaration?
    void setIsShared(bool val) { cuda_shared_ = val; }

    virtual void serialize(Serializer& s) const;


    // TODO: replace with LLVM-style casting
    static CudaVariableDeclarationExpression* downcast(Expression* s) {
        auto result = dynamic_cast<CudaVariableDeclarationExpression*>(s);
        if (!result)
            throw_gpusim_exception("Downcast failed: incorrect type");
        return result;
    }

protected:
    bool cuda_shared_ = false;
};

/**
 * @author JKM
 * @brief CUDA function
 */
class CudaFunction : public Function {
public:
    using Function::Function;
    virtual void serialize(Serializer& s) const;

    // TODO: replace with LLVM-style casting
    static CudaFunction* downcast(Function* f) {
        auto result = dynamic_cast<CudaFunction*>(f);
        if (!result)
            throw_gpusim_exception("Downcast failed: incorrect type");
        return result;
    }
};

/**
 * @author JKM
 * @brief CUDA function
 */
class CudaKernel : public CudaFunction {
public:
    using CudaFunction::CudaFunction;

    CudaKernel(CudaKernel&& other) = default;
    ~CudaKernel() {}

    enum class IndexComponent {
        x,
        y,
        z
    };

    /// Get the expression for threadIdx
    VariableRefExpression getThreadIdx() const {
        return VariableRefExpression(threadidx_.get());
    }

    /// Get the expression for threadIdx with the specified component
    MemberAccessExpression getThreadIdx(IndexComponent c) const {
        switch (c) {
            case IndexComponent::x:
                return MemberAccessExpression(getThreadIdx(), SymbolExpression("x"));
            case IndexComponent::y:
                return MemberAccessExpression(getThreadIdx(), SymbolExpression("y"));
            case IndexComponent::z:
                return MemberAccessExpression(getThreadIdx(), SymbolExpression("z"));
        }
    }

    /// Get the expression for blockIdx
    VariableRefExpression getBlockIdx() const {
        return VariableRefExpression(blockidx_.get());
    }

    /// Get the expression for blockIdx with the specified component
    MemberAccessExpression getBlockIdx(IndexComponent c) const {
        switch (c) {
            case IndexComponent::x:
                return MemberAccessExpression(getBlockIdx(), SymbolExpression("x"));
            case IndexComponent::y:
                return MemberAccessExpression(getBlockIdx(), SymbolExpression("y"));
            case IndexComponent::z:
                return MemberAccessExpression(getBlockIdx(), SymbolExpression("z"));
        }
    }

    virtual bool requiresSpecialCallingConvention() const { return true; }

    virtual void serialize(Serializer& s) const;

    // TODO: replace with LLVM-style casting
    static CudaKernel* downcast(Function* f) {
        auto result = dynamic_cast<CudaKernel*>(f);
        if (!result)
            throw_gpusim_exception("Downcast failed: incorrect type");
        return result;
    }

protected:
    VariablePtr threadidx_{new Variable(BaseTypes::getTp(BaseTypes::INT), "threadIdx")};
    VariablePtr blockidx_ {new Variable(BaseTypes::getTp(BaseTypes::INT), "blockIdx")};
};
typedef std::unique_ptr<CudaKernel> CudaKernelPtr;

/**
 * @author JKM
 * @brief A class to encapsulate expressions
 */
class CudaKernelCallExpression : public FunctionCallExpression {
public:
    CudaKernelCallExpression(int nblocks, int nthreads, int shared_mem_size, Function* func);

    /// N-arg ctor
    template <class... Args>
    CudaKernelCallExpression(int nblocks, int nthreads, int shared_mem_size, Function* func, Args&&... args)
      : FunctionCallExpression(func, std::forward<Args>(args)...) {
        nblocks_.reset(new LiteralIntExpression(nblocks));
        nthreads_.reset(new LiteralIntExpression(nthreads));
        shared_mem_size_.reset(new LiteralIntExpression(shared_mem_size));
    }

    /// Set the expression for the shared memory size
    void setSharedMemSize(ExpressionPtr&& exp) {
        shared_mem_size_ = std::move(exp);
    }

    /// Set the expression for the shared memory size
    template <class ExpressionT>
    void setSharedMemSize(ExpressionT&& exp) {
        setSharedMemSize(ExpressionPtr(new ExpressionT(std::move(exp))));
    }

    virtual void serialize(Serializer& s) const;

    // TODO: replace with LLVM-style casting
    static CudaKernelCallExpression* downcast(Expression* s) {
        auto result = dynamic_cast<CudaKernelCallExpression*>(s);
        if (!result)
            throw_gpusim_exception("Downcast failed: incorrect type");
        return result;
    }

protected:
    ExpressionPtr nblocks_;
    ExpressionPtr nthreads_;
    ExpressionPtr shared_mem_size_;
};

/**
 * @author JKM
 * @brief CUDA module
 */
class CudaModule : public Module {
public:
    typedef std::unique_ptr<CudaFunction> CudaFunctionPtr;

    CudaModule()
      : printf_(new Function("printf",
                             BaseTypes::getTp(BaseTypes::INT),
                             FunctionParameterPtr(new FunctionParameter(BaseTypes::getTp(BaseTypes::CSTR), "format_str")))),
        cudaDeviceSynchronize_(new Function("cudaDeviceSynchronize",
                                            BaseTypes::getTp(BaseTypes::VOID)))
        {
        printf_->setIsVarargs(true);
    }

    /// Serialize to a .cu source file
    virtual void serialize(Serializer& s) const;

    CudaFunction* addFunction(CudaFunction&& f) {
        return addFunction(CudaFunctionPtr(new CudaFunction(std::move(f))));
    }

    CudaFunction* addFunction(CudaKernel&& f) {
        return addFunction(CudaFunctionPtr(new CudaKernel(std::move(f))));
    }

    CudaFunction* addFunction(CudaFunctionPtr&& f) {
        func_.emplace_back(std::move(f));
        return CudaFunction::downcast(func_.back().get());
    }

    const Function* getPrintf() const {
        return printf_.get();
    }

    const Function* getCudaDeviceSynchronize() {
        return cudaDeviceSynchronize_.get();
    }

protected:
    FunctionPtr printf_;
    FunctionPtr cudaDeviceSynchronize_;
};

} // namespace dom

} // namespace rrgpu

} // namespace rr

#endif // header guard