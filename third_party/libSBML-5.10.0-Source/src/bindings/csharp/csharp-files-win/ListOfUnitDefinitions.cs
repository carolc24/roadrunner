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
@htmlinclude pkg-marker-core.html Implementation of SBML's %ListOfUnitDefinitions
 * construct.
 * 
 * *
 * 
 * The various ListOf___ @if conly structures @else classes@endif in SBML
 * are merely containers used for organizing the main components of an SBML
 * model.  In libSBML's implementation, ListOf___
 * @if conly data structures @else classes@endif are derived from the
 * intermediate utility @if conly structure @else class@endif ListOf, which
 * is not defined by the SBML specifications but serves as a useful
 * programmatic construct.  ListOf is itself is in turn derived from SBase,
 * which provides all of the various ListOf___
 * @if conly data structures @else classes@endif with common features
 * defined by the SBML specification, such as 'metaid' attributes and
 * annotations.
 *
 * The relationship between the lists and the rest of an SBML model is
 * illustrated by the following (for SBML Level&nbsp;2 Version&nbsp;4):
 *
 * @htmlinclude listof-illustration.html
 *
 * Readers may wonder about the motivations for using the ListOf___
 * containers in SBML.  A simpler approach in XML might be to place the
 * components all directly at the top level of the model definition.  The
 * choice made in SBML is to group them within XML elements named after
 * %ListOf<em>Classname</em>, in part because it helps organize the
 * components.  More importantly, the fact that the container classes are
 * derived from SBase means that software tools can add information @em about
 * the lists themselves into each list container's 'annotation'.
 *
 * @see ListOfFunctionDefinitions
 * @see ListOfUnitDefinitions
 * @see ListOfCompartmentTypes
 * @see ListOfSpeciesTypes
 * @see ListOfCompartments
 * @see ListOfSpecies
 * @see ListOfParameters
 * @see ListOfInitialAssignments
 * @see ListOfRules
 * @see ListOfConstraints
 * @see ListOfReactions
 * @see ListOfEvents
 *
 * @if conly
 * @note In the C API for libSBML, functions that in other language APIs
 * would be inherited by the various ListOf___ structures not shown in the
 * pages for the individual ListOf___'s.  Instead, the functions are defined
 * on ListOf_t.  <strong>Please consult the documentation for ListOf_t for
 * the many common functions available for manipulating ListOf___
 * structures</strong>.  The documentation for the individual ListOf___
 * structures (ListOfCompartments_t, ListOfReactions_t, etc.) does not reveal
 * all of the functionality available. @endif
 *
 *
 */

public class ListOfUnitDefinitions : ListOf {
	private HandleRef swigCPtr;
	
	internal ListOfUnitDefinitions(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.ListOfUnitDefinitions_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ListOfUnitDefinitionsUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ListOfUnitDefinitions obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ListOfUnitDefinitions obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ListOfUnitDefinitions() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ListOfUnitDefinitions(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new ListOfUnitDefinitions object.
   *
   * The object is constructed such that it is valid for the given SBML
   * Level and Version combination.
   *
   * @param level the SBML Level
   * 
   * @param version the Version within the SBML Level
   */ public
 ListOfUnitDefinitions(long level, long version) : this(libsbmlPINVOKE.new_ListOfUnitDefinitions__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOfUnitDefinitions object.
   *
   * The object is constructed such that it is valid for the SBML Level and
   * Version combination determined by the SBMLNamespaces object in @p
   * sbmlns.
   *
   * @param sbmlns an SBMLNamespaces object that is used to determine the
   * characteristics of the ListOfUnitDefinitions object to be created.
   */ public
 ListOfUnitDefinitions(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_ListOfUnitDefinitions__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ListOfUnitDefinitions instance.
   *
   * @return a (deep) copy of this ListOfUnitDefinitions.
   */ public new
 ListOfUnitDefinitions clone() {
    IntPtr cPtr = libsbmlPINVOKE.ListOfUnitDefinitions_clone(swigCPtr);
    ListOfUnitDefinitions ret = (cPtr == IntPtr.Zero) ? null : new ListOfUnitDefinitions(cPtr, true);
    return ret;
  }

  
/**
   * Returns the libSBML type code for the objects contained in this ListOf
   * (i.e., UnitDefinition objects, if the list is non-empty).
   *
   * *
 *  
 * LibSBML attaches an identifying code to every kind of SBML object.  These
 * are integer constants known as <em>SBML type codes</em>.  The names of all
 * the codes begin with the characters &ldquo;<code>SBML_</code>&rdquo;. 
 * @if clike The set of possible type codes for core elements is defined in
 * the enumeration #SBMLTypeCode_t, and in addition, libSBML plug-ins for
 * SBML Level&nbsp;3 packages define their own extra enumerations of type
 * codes (e.g., #SBMLLayoutTypeCode_t for the Level&nbsp;3 Layout
 * package).@endif@if java In the Java language interface for libSBML, the
 * type codes are defined as static integer constants in the interface class
 * {@link libsbmlConstants}.  @endif@if python In the Python language
 * interface for libSBML, the type codes are defined as static integer
 * constants in the interface class @link libsbml@endlink.@endif@if csharp In
 * the C# language interface for libSBML, the type codes are defined as
 * static integer constants in the interface class
 * @link libsbmlcs.libsbml@endlink.@endif  Note that different Level&nbsp;3 
 * package plug-ins may use overlapping type codes; to identify the package
 * to which a given object belongs, call the <code>getPackageName()</code>
 * method on the object.
 * 
 *
   *
   * @return the SBML type code for objects contained in this list:
   * @link libsbmlcs.libsbml.SBML_UNIT_DEFINITION SBML_UNIT_DEFINITION@endlink (default).
   *
   * @see getElementName()
   * @see getPackageName()
   */ public new
 int getItemTypeCode() {
    int ret = libsbmlPINVOKE.ListOfUnitDefinitions_getItemTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object.
   *
   * For ListOfUnitDefinitions, the XML element name is @c
   * 'listOfUnitDefinitions'.
   * 
   * @return the name of this element, i.e., @c 'listOfUnitDefinitions'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.ListOfUnitDefinitions_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Get a UnitDefinition from the ListOfUnitDefinitions.
   *
   * @param n the index number of the UnitDefinition to get.
   * 
   * @return the nth UnitDefinition in this ListOfUnitDefinitions.
   *
   * @see size()
   */ public new
 UnitDefinition get(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfUnitDefinitions_get__SWIG_0(swigCPtr, n);
    UnitDefinition ret = (cPtr == IntPtr.Zero) ? null : new UnitDefinition(cPtr, false);
    return ret;
  }

  
/**
   * Get a UnitDefinition from the ListOfUnitDefinitions
   * based on its identifier.
   *
   * @param sid a string representing the identifier 
   * of the UnitDefinition to get.
   * 
   * @return UnitDefinition in this ListOfUnitDefinitions
   * with the given @p sid or @c null if no such
   * UnitDefinition exists.
   *
   * @see get(long n)
   * @see size()
   */ public new
 UnitDefinition get(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfUnitDefinitions_get__SWIG_2(swigCPtr, sid);
    UnitDefinition ret = (cPtr == IntPtr.Zero) ? null : new UnitDefinition(cPtr, false);
    return ret;
  }

  
/**
   * Returns the first child element found that has the given @p id in the
   * model-wide SId namespace, or @c null if no such object is found.
   *
   * Note that UnitDefinitions themselves are in the UnitId namespace, not
   * the SId namespace, so no UnitDefinition object will be returned from
   * this function (and is the reason we override the base
   * ListOf::getElementBySId function here).
   *
   * @param id string representing the id of objects to find
   *
   * @return pointer to the first element found with the given @p id.
   */ public
 SBase getElementBySId(string id) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.ListOfUnitDefinitions_getElementBySId(swigCPtr, id), false);
	return ret;
}

  
/**
   * Removes the nth item from this ListOfUnitDefinitions items and returns a pointer to
   * it.
   *
   * The caller owns the returned item and is responsible for deleting it.
   *
   * @param n the index of the item to remove
   *
   * @see size()
   */ public new
 UnitDefinition remove(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfUnitDefinitions_remove__SWIG_0(swigCPtr, n);
    UnitDefinition ret = (cPtr == IntPtr.Zero) ? null : new UnitDefinition(cPtr, true);
    return ret;
  }

  
/**
   * Removes item in this ListOfUnitDefinitions items with the given identifier.
   *
   * The caller owns the returned item and is responsible for deleting it.
   * If none of the items in this list have the identifier @p sid, then @c
   * null is returned.
   *
   * @param sid the identifier of the item to remove
   *
   * @return the item removed.  As mentioned above, the caller owns the
   * returned item.
   */ public new
 UnitDefinition remove(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfUnitDefinitions_remove__SWIG_1(swigCPtr, sid);
    UnitDefinition ret = (cPtr == IntPtr.Zero) ? null : new UnitDefinition(cPtr, true);
    return ret;
  }

}

}
