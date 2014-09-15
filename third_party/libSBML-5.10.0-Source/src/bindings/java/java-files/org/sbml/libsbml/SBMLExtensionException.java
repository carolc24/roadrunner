/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 *  Exceptions for libSBML extensions for SBML Level 3 packages.
 */

public class SBMLExtensionException {
   private long swigCPtr;
   protected boolean swigCMemOwn;

   protected SBMLExtensionException(long cPtr, boolean cMemoryOwn)
   {
     swigCMemOwn = cMemoryOwn;
     swigCPtr    = cPtr;
   }

   protected static long getCPtr(SBMLExtensionException obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (SBMLExtensionException obj)
   {
     long ptr = 0;

     if (obj != null)
     {
       ptr             = obj.swigCPtr;
       obj.swigCMemOwn = false;
     }

     return ptr;
   }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libsbmlJNI.delete_SBMLExtensionException(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  
/** 
   * constructor 
   */ public
 SBMLExtensionException(String errmsg) {
    this(libsbmlJNI.new_SBMLExtensionException(errmsg), true);
  }

}
