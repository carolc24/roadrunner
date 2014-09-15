/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbmlcs {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html Base class for SBML converters.
 *
 * @htmlinclude libsbml-facility-only-warning.html
 *
 * The SBMLConverter class is the base class for the various SBML @em
 * converters: classes of objects that transform or convert SBML documents.
 * These transformations can involve essentially anything that can be
 * written algorithmically; examples include converting the units of
 * measurement in a model, or converting from one Level+Version combination
 * of SBML to another.
 *
 * LibSBML provides a number of built-in converters, and applications can
 * create their own by subclassing SBMLConverter and following the examples
 * of the existing converters.  The following are the built-in converters
 * in libSBML @htmlinclude libsbml-version.html:
 * @li SBMLFunctionDefinitionConverter
 * @li SBMLInitialAssignmentConverter
 * @li SBMLLevelVersionConverter
 * @li SBMLRuleConverter
 * @li SBMLStripPackageConverter
 * @li SBMLUnitsConverter
 *
 * Many converters provide the ability to configure their behavior to some
 * extent.  This is realized through the use of @em properties that offer
 * different @em options.  Two related classes implement these features:
 * ConversionProperties and ConversionOptions.  The default property values
 * for each converter can be interrogated using the method
 * SBMLConverter::getDefaultProperties() on the converter class.
 */

public class SBMLConverter : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal SBMLConverter(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLConverter obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLConverter obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLConverter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLConverter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Creates a new SBMLConverter object.
   */ public
 SBMLConverter() : this(libsbmlPINVOKE.new_SBMLConverter__SWIG_0(), true) {
    SwigDirectorConnect();
  }

  
/**
   * Copy constructor; creates a copy of an SBMLConverter object.
   *
   * @param c the SBMLConverter object to copy.
   * 
   * @throws @if python ValueError @else SBMLConstructorException @endif
   * Thrown if the argument @p orig is @c null.
   */ public
 SBMLConverter(SBMLConverter c) : this(libsbmlPINVOKE.new_SBMLConverter__SWIG_1(SBMLConverter.getCPtr(c)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  
/**
   * Creates and returns a deep copy of this SBMLConverter object.
   * 
   * @return a (deep) copy of this SBMLConverter object.
   */ public
 SBMLConverter clone() {
    IntPtr cPtr = (SwigDerivedClassHasMethod("clone", swigMethodTypes0) ? libsbmlPINVOKE.SBMLConverter_cloneSwigExplicitSBMLConverter(swigCPtr) : libsbmlPINVOKE.SBMLConverter_clone(swigCPtr));
    SBMLConverter ret = (cPtr == IntPtr.Zero) ? null : new SBMLConverter(cPtr, true);
    return ret;
  }

  
/**
   * Returns the SBML document that is the subject of the conversions.
   *
   * @return the current SBMLDocument object.
   */ public
 SBMLDocument getDocument() {
    IntPtr cPtr = (SwigDerivedClassHasMethod("getDocument", swigMethodTypes1) ? libsbmlPINVOKE.SBMLConverter_getDocumentSwigExplicitSBMLConverter__SWIG_0(swigCPtr) : libsbmlPINVOKE.SBMLConverter_getDocument__SWIG_0(swigCPtr));
    SBMLDocument ret = (cPtr == IntPtr.Zero) ? null : new SBMLDocument(cPtr, false);
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
    ConversionProperties ret = new ConversionProperties((SwigDerivedClassHasMethod("getDefaultProperties", swigMethodTypes3) ? libsbmlPINVOKE.SBMLConverter_getDefaultPropertiesSwigExplicitSBMLConverter(swigCPtr) : libsbmlPINVOKE.SBMLConverter_getDefaultProperties(swigCPtr)), true);
    return ret;
  }

  
/**
   * Returns the target SBML namespaces of the currently set properties.
   *
   * SBML namespaces are used by libSBML to express the Level+Version of
   * the SBML document (and, possibly, any SBML Level&nbsp;3 packages in
   * use). Some converters' behavior is affected by the SBML namespace
   * configured in the converter.  For example, the actions of
   * SBMLLevelVersionConverter, the converter for converting SBML documents
   * from one Level+Version combination to another, are fundamentally
   * dependent on the SBML namespaces being targeted.
   *
   * @return the SBMLNamespaces object that describes the SBML namespaces
   * in effect.
   */ public
 SBMLNamespaces getTargetNamespaces() {
	SBMLNamespaces ret
	    = (SBMLNamespaces) libsbml.DowncastSBMLNamespaces((SwigDerivedClassHasMethod("getTargetNamespaces", swigMethodTypes4) ? libsbmlPINVOKE.SBMLConverter_getTargetNamespacesSwigExplicitSBMLConverter(swigCPtr) : libsbmlPINVOKE.SBMLConverter_getTargetNamespaces(swigCPtr)), false);
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
    bool ret = (SwigDerivedClassHasMethod("matchesProperties", swigMethodTypes5) ? libsbmlPINVOKE.SBMLConverter_matchesPropertiesSwigExplicitSBMLConverter(swigCPtr, ConversionProperties.getCPtr(props)) : libsbmlPINVOKE.SBMLConverter_matchesProperties(swigCPtr, ConversionProperties.getCPtr(props)));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the current SBML document to the given SBMLDocument object.
   * 
   * @param doc the document to use for this conversion.
   * 
   * @return integer value indicating the success/failure of the operation.
   * @if clike The value is drawn from the enumeration
   * #OperationReturnValues_t. @endif The set of possible values that may
   * be returned ultimately depends on the specific subclass of
   * SBMLConverter being used, but the default method can return the
   * following values:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   */ public
 int setDocument(SBMLDocument doc) {
    int ret = (SwigDerivedClassHasMethod("setDocument", swigMethodTypes6) ? libsbmlPINVOKE.SBMLConverter_setDocumentSwigExplicitSBMLConverter(swigCPtr, SBMLDocument.getCPtr(doc)) : libsbmlPINVOKE.SBMLConverter_setDocument(swigCPtr, SBMLDocument.getCPtr(doc)));
    return ret;
  }

  
/**
   * Sets the configuration properties to be used by this converter.
   * 
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method sets
   * the current properties for this converter.
   *
   * @param props the ConversionProperties object defining the properties
   * to set.
   * 
   * @return integer value indicating the success/failure of the operation.
   * @if clike The value is drawn from the enumeration
   * #OperationReturnValues_t. @endif The set of possible values that may
   * be returned ultimately depends on the specific subclass of
   * SBMLConverter being used, but the default method can return the
   * following values:
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link libsbmlcs.libsbml.LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   *
   * @see getProperties()
   * @see matchesProperties(@if java ConversionProperties props@endif)
   */ public
 int setProperties(ConversionProperties props) {
    int ret = (SwigDerivedClassHasMethod("setProperties", swigMethodTypes7) ? libsbmlPINVOKE.SBMLConverter_setPropertiesSwigExplicitSBMLConverter(swigCPtr, ConversionProperties.getCPtr(props)) : libsbmlPINVOKE.SBMLConverter_setProperties(swigCPtr, ConversionProperties.getCPtr(props)));
    return ret;
  }

  
/**
   * Returns the current properties in effect for this converter.
   * 
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method
   * returns the current properties for this converter; in other words, the
   * settings in effect at this moment.  To change the property values, you
   * can use SBMLConverter::setProperties(ConversionProperties props).
   * 
   * @return the currently set configuration properties.
   *
   * @see setProperties(@if java ConversionProperties props@endif)
   * @see matchesProperties(@if java ConversionProperties props@endif)
   */ public
 ConversionProperties getProperties() {
    IntPtr cPtr = (SwigDerivedClassHasMethod("getProperties", swigMethodTypes8) ? libsbmlPINVOKE.SBMLConverter_getPropertiesSwigExplicitSBMLConverter(swigCPtr) : libsbmlPINVOKE.SBMLConverter_getProperties(swigCPtr));
    ConversionProperties ret = (cPtr == IntPtr.Zero) ? null : new ConversionProperties(cPtr, false);
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
    int ret = (SwigDerivedClassHasMethod("convert", swigMethodTypes9) ? libsbmlPINVOKE.SBMLConverter_convertSwigExplicitSBMLConverter(swigCPtr) : libsbmlPINVOKE.SBMLConverter_convert(swigCPtr));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("clone", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateSBMLConverter_0(SwigDirectorclone);
    if (SwigDerivedClassHasMethod("getDocument", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateSBMLConverter_1(SwigDirectorgetDocument__SWIG_0);
    if (SwigDerivedClassHasMethod("getDocument", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateSBMLConverter_2(SwigDirectorgetDocument__SWIG_1);
    if (SwigDerivedClassHasMethod("getDefaultProperties", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateSBMLConverter_3(SwigDirectorgetDefaultProperties);
    if (SwigDerivedClassHasMethod("getTargetNamespaces", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateSBMLConverter_4(SwigDirectorgetTargetNamespaces);
    if (SwigDerivedClassHasMethod("matchesProperties", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateSBMLConverter_5(SwigDirectormatchesProperties);
    if (SwigDerivedClassHasMethod("setDocument", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateSBMLConverter_6(SwigDirectorsetDocument);
    if (SwigDerivedClassHasMethod("setProperties", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateSBMLConverter_7(SwigDirectorsetProperties);
    if (SwigDerivedClassHasMethod("getProperties", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateSBMLConverter_8(SwigDirectorgetProperties);
    if (SwigDerivedClassHasMethod("convert", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateSBMLConverter_9(SwigDirectorconvert);
    libsbmlPINVOKE.SBMLConverter_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(SBMLConverter));
    return hasDerivedMethod;
  }

  private IntPtr SwigDirectorclone() {
    return SBMLConverter.getCPtr(clone()).Handle;
  }

  private IntPtr SwigDirectorgetDocument__SWIG_0() {
    return SBMLDocument.getCPtr(getDocument()).Handle;
  }

  private IntPtr SwigDirectorgetDocument__SWIG_1() {
    return SBMLDocument.getCPtr(getDocument()).Handle;
  }

  private IntPtr SwigDirectorgetDefaultProperties() {
    return ConversionProperties.getCPtr(getDefaultProperties()).Handle;
  }

  private IntPtr SwigDirectorgetTargetNamespaces() {
    return SBMLNamespaces.getCPtr(getTargetNamespaces()).Handle;
  }

  private bool SwigDirectormatchesProperties(IntPtr props) {
    return matchesProperties(new ConversionProperties(props, false));
  }

  private int SwigDirectorsetDocument(IntPtr doc) {
    return setDocument((doc == IntPtr.Zero) ? null : new SBMLDocument(doc, false));
  }

  private int SwigDirectorsetProperties(IntPtr props) {
    return setProperties((props == IntPtr.Zero) ? null : new ConversionProperties(props, false));
  }

  private IntPtr SwigDirectorgetProperties() {
    return ConversionProperties.getCPtr(getProperties()).Handle;
  }

  private int SwigDirectorconvert() {
    return convert();
  }

  public delegate IntPtr SwigDelegateSBMLConverter_0();
  public delegate IntPtr SwigDelegateSBMLConverter_1();
  public delegate IntPtr SwigDelegateSBMLConverter_2();
  public delegate IntPtr SwigDelegateSBMLConverter_3();
  public delegate IntPtr SwigDelegateSBMLConverter_4();
  public delegate bool SwigDelegateSBMLConverter_5(IntPtr props);
  public delegate int SwigDelegateSBMLConverter_6(IntPtr doc);
  public delegate int SwigDelegateSBMLConverter_7(IntPtr props);
  public delegate IntPtr SwigDelegateSBMLConverter_8();
  public delegate int SwigDelegateSBMLConverter_9();

  private SwigDelegateSBMLConverter_0 swigDelegate0;
  private SwigDelegateSBMLConverter_1 swigDelegate1;
  private SwigDelegateSBMLConverter_2 swigDelegate2;
  private SwigDelegateSBMLConverter_3 swigDelegate3;
  private SwigDelegateSBMLConverter_4 swigDelegate4;
  private SwigDelegateSBMLConverter_5 swigDelegate5;
  private SwigDelegateSBMLConverter_6 swigDelegate6;
  private SwigDelegateSBMLConverter_7 swigDelegate7;
  private SwigDelegateSBMLConverter_8 swigDelegate8;
  private SwigDelegateSBMLConverter_9 swigDelegate9;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] {  };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(ConversionProperties) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(SBMLDocument) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(ConversionProperties) };
  private static Type[] swigMethodTypes8 = new Type[] {  };
  private static Type[] swigMethodTypes9 = new Type[] {  };
}

}
