/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html SBML converter for transforming documents from one
 * Level+Version to another.
 *
 * @htmlinclude libsbml-facility-only-warning.html
 *
 * This SBML converter takes an SBML document of one SBML Level+Version
 * combination and attempts to convert it to another Level+Version combination.
 * The target Level+Version is set using an SBMLNamespace object in the
 * ConversionProperties object that controls this converter.
 *
 * This class is the basis for
 * SBMLDocument::setLevelAndVersion(@if java long lev, long ver, bool strict@endif).
 * 
 * @see SBMLFunctionDefinitionConverter
 * @see SBMLInitialAssignmentConverter
 * @see SBMLRuleConverter
 * @see SBMLStripPackageConverter
 * @see SBMLUnitsConverter
 */

public class SBMLLevelVersionConverter : SBMLConverter {
	private HandleRef swigCPtr;
	
	internal SBMLLevelVersionConverter(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SBMLLevelVersionConverter_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SBMLLevelVersionConverterUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLLevelVersionConverter obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLLevelVersionConverter obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLLevelVersionConverter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLLevelVersionConverter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static void init() {
    libsbmlPINVOKE.SBMLLevelVersionConverter_init();
  }

  
/**
   * Creates a new SBMLLevelVersionConverter object.
   */ public
 SBMLLevelVersionConverter() : this(libsbmlPINVOKE.new_SBMLLevelVersionConverter__SWIG_0(), true) {
  }

  
/**
   * Copy constructor; creates a copy of an SBMLLevelVersionConverter
   * object.
   *
   * @param obj the SBMLLevelVersionConverter object to copy.
   */ public
 SBMLLevelVersionConverter(SBMLLevelVersionConverter obj) : this(libsbmlPINVOKE.new_SBMLLevelVersionConverter__SWIG_1(SBMLLevelVersionConverter.getCPtr(obj)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this SBMLConverter object.
   * 
   * @return a (deep) copy of this SBMLConverter object.
   */ public
 SBMLConverter clone() {
    IntPtr cPtr = libsbmlPINVOKE.SBMLLevelVersionConverter_clone(swigCPtr);
    SBMLLevelVersionConverter ret = (cPtr == IntPtr.Zero) ? null : new SBMLLevelVersionConverter(cPtr, true);
    return ret;
  }

  
/**
   * Predicate returning @c true if this converter's properties matches a
   * given set of configuration properties.
   * 
   * @param props the configuration properties to match.
   * 
   * @return @c true if this converter's properties match, @c false
   * otherwise.
   */ public
 bool matchesProperties(ConversionProperties props) {
    bool ret = libsbmlPINVOKE.SBMLLevelVersionConverter_matchesProperties(swigCPtr, ConversionProperties.getCPtr(props));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Perform the conversion.
   *
   * This method causes the converter to do the actual conversion work,
   * that is, to convert the SBMLDocument object set by
   * SBMLConverter::setDocument(@if java SBMLDocument doc@endif) and
   * with the configuration options set by
   * SBMLConverter::setProperties(@if java ConversionProperties props@endif).
   * 
   * @return  integer value indicating the success/failure of the operation.
   * @if clike The value is drawn from the enumeration
   * #OperationReturnValues_t. @endif The set of possible values that may
   * be returned depends on the converter subclass; please consult
   * the documentation for the relevant class to find out what the
   * possibilities are.
   */ public
 int convert() {
    int ret = libsbmlPINVOKE.SBMLLevelVersionConverter_convert(swigCPtr);
    return ret;
  }

  
/**
   * Returns the default properties of this converter.
   *
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method
   * returns the @em default property settings for this converter.  It is
   * meant to be called in order to discover all the settings for the
   * converter object.  The run-time properties of the converter object can
   * be adjusted by using the method
   * SBMLConverter::setProperties(ConversionProperties props).
   * 
   * @return the default properties for the converter.
   *
   * @see setProperties(@if java ConversionProperties props@endif)
   * @see matchesProperties(@if java ConversionProperties props@endif)
   */ public
 ConversionProperties getDefaultProperties() {
    ConversionProperties ret = new ConversionProperties(libsbmlPINVOKE.SBMLLevelVersionConverter_getDefaultProperties(swigCPtr), true);
    return ret;
  }

  
/**
   * Returns the target SBML Level for the conversion.
   *
   * @return an integer indicating the SBML Level.
   */ public
 long getTargetLevel() { return (long)libsbmlPINVOKE.SBMLLevelVersionConverter_getTargetLevel(swigCPtr); }

  
/**
   * Returns the target SBML Version for the conversion.
   *
   * @return an integer indicating the Version within the SBML Level.
   */ public
 long getTargetVersion() { return (long)libsbmlPINVOKE.SBMLLevelVersionConverter_getTargetVersion(swigCPtr); }

  
/**
   * Returns the flag indicating whether the conversion has been set to 'strict'.
   *
   * @return @c true if strict validity has been requested, @c false
   * otherwise.
   */ public
 bool getValidityFlag() {
    bool ret = libsbmlPINVOKE.SBMLLevelVersionConverter_getValidityFlag(swigCPtr);
    return ret;
  }

}

}
