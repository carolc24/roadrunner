/**
 * @file:   Input.h
 * @brief:  Implementation of the Input class
 * @author: Generated by autocreate code
 *
 * <!--------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright (C) 2009-2013 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EBML-EBI), Hinxton, UK
 *
 * Copyright (C) 2006-2008 by the California Institute of Technology,
 *     Pasadena, CA, USA 
 *
 * Copyright (C) 2002-2005 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. Japan Science and Technology Agency, Japan
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * ------------------------------------------------------------------------ -->
 *
 * @class Input
 * @sbmlbrief{qual} The Input class for the Qualitative Models package.
 *
 * Each Input refers to a QualitativeSpecies that participates in the corresponding Transition. In Petri nets, these are the input places of the transition. In logical models, they are the regulators of the species whose behaviour is defined by the transition.
 */


#ifndef Input_H__
#define Input_H__


#include <sbml/common/extern.h>
#include <sbml/common/sbmlfwd.h>
#include <sbml/packages/qual/common/qualfwd.h>

LIBSBML_CPP_NAMESPACE_BEGIN

/**
 * @enum InputTransitionEffect_t
 * Enumeration of possible values for the 'transitionEffect' attribute of an Input.  Must be 'none' or 'consumption'.
 */
typedef enum
{
    INPUT_TRANSITION_EFFECT_NONE /*!< 'none': The level associated with the qualitativeSpecies is not modified. */
  , INPUT_TRANSITION_EFFECT_CONSUMPTION /*!< 'consumption': The level of the qualitativeSpecies is decreased by the resultLevel of the applicable FunctionTerm possibly modified by the thresholdLevel of the Input. */
  , INPUT_TRANSITION_EFFECT_UNKNOWN /*!< Unknown or illegal value:  anything other than 'none' or 'consumption'. */
} InputTransitionEffect_t;

/**
 * @enum InputSign_t
 * Enumeration of possible values for the 'transitionEffect' attribute of an Input.  Must be 'positive', 'negative', 'dual', or 'unknown'.
 */
typedef enum
{
    INPUT_SIGN_POSITIVE /*!< 'positive': The contribution of this input is positive. */
  , INPUT_SIGN_NEGATIVE /*!< 'negative': The contribution of this input is negative. */
  , INPUT_SIGN_DUAL /*!< 'dual': The contribution of this input is both negative and positive. */
  , INPUT_SIGN_UNKNOWN /*!< 'unknown': The contribution of this input is unknown. */
  , INPUT_SIGN_VALUE_NOTSET /*!< unset or illegal value: Anything other than 'positive', 'negative', 'dual', or 'unknown'. */
} InputSign_t;

LIBSBML_CPP_NAMESPACE_END


#ifdef __cplusplus


#include <string>


#include <sbml/SBase.h>
#include <sbml/ListOf.h>
#include <sbml/packages/qual/extension/QualExtension.h>


LIBSBML_CPP_NAMESPACE_BEGIN


class LIBSBML_EXTERN Input : public SBase
{

protected:

  std::string   mId;
  std::string   mQualitativeSpecies;
  InputTransitionEffect_t   mTransitionEffect;
  std::string   mName;
  InputSign_t   mSign;
  int           mThresholdLevel;
  bool          mIsSetThresholdLevel;


public:

  /**
   * Creates a new Input with the given level, version, and package version.
   *
   * @param level an unsigned int, the SBML Level to assign to this Input
   *
   * @param version an unsigned int, the SBML Version to assign to this Input
   *
   * @param pkgVersion an unsigned int, the SBML Qual Version to assign to this Input
   */
  Input(unsigned int level      = QualExtension::getDefaultLevel(),
        unsigned int version    = QualExtension::getDefaultVersion(),
        unsigned int pkgVersion = QualExtension::getDefaultPackageVersion());


  /**
   * Creates a new Input with the given QualPkgNamespaces object.
   *
   * @param qualns the QualPkgNamespaces object
   */
  Input(QualPkgNamespaces* qualns);


  /**
   * Copy constructor for Input.
   *
   * @param orig the Input instance to copy.
   */
  Input(const Input& orig);


  /**
   * Assignment operator for Input.
   *
   * @param rhs the object whose values are used as the basis
   * of the assignment
   */
  Input& operator=(const Input& rhs);


  /**
   * Creates and returns a deep copy of this Input object.
   *
   * @return a (deep) copy of this Input object.
   */
  virtual Input* clone () const;


  /**
   * Destructor for Input.
   */
  virtual ~Input();


  /**
   * Returns the value of the "id" attribute of this Input.
   *
   * @return the value of the "id" attribute of this Input as a string.
   */
  virtual const std::string& getId() const;


  /**
   * Returns the value of the "qualitativeSpecies" attribute of this Input.
   *
   * @return the value of the "qualitativeSpecies" attribute of this Input as a string.
   */
  virtual const std::string& getQualitativeSpecies() const;


  /**
   * Returns the value of the "transitionEffect" attribute of this Input.
   *
   * @return the value of the "transitionEffect" attribute of this Input as a string.
   */
  const InputTransitionEffect_t getTransitionEffect() const;


  /**
   * Returns the value of the "name" attribute of this Input.
   *
   * @return the value of the "name" attribute of this Input as a string.
   */
  virtual const std::string& getName() const;


  /**
   * Returns the value of the "sign" attribute of this Input.
   *
   * @return the value of the "sign" attribute of this Input as a string.
   */
  const InputSign_t getSign() const;


  /**
   * Returns the value of the "thresholdLevel" attribute of this Input.
   *
   * @return the value of the "thresholdLevel" attribute of this Input as a integer.
   */
  virtual const int getThresholdLevel() const;


  /**
   * Predicate returning @c true or @c false depending on whether this
   * Input's "id" attribute has been set.
   *
   * @return @c true if this Input's "id" attribute has been set,
   * otherwise @c false is returned.
   */
  virtual bool isSetId() const;


  /**
   * Predicate returning @c true or @c false depending on whether this
   * Input's "qualitativeSpecies" attribute has been set.
   *
   * @return @c true if this Input's "qualitativeSpecies" attribute has been set,
   * otherwise @c false is returned.
   */
  virtual bool isSetQualitativeSpecies() const;


  /**
   * Predicate returning @c true or @c false depending on whether this
   * Input's "transitionEffect" attribute has been set.
   *
   * @return @c true if this Input's "transitionEffect" attribute has been set,
   * otherwise @c false is returned.
   */
  bool isSetTransitionEffect() const;


  /**
   * Predicate returning @c true or @c false depending on whether this
   * Input's "name" attribute has been set.
   *
   * @return @c true if this Input's "name" attribute has been set,
   * otherwise @c false is returned.
   */
  virtual bool isSetName() const;


  /**
   * Predicate returning @c true or @c false depending on whether this
   * Input's "sign" attribute has been set.
   *
   * @return @c true if this Input's "sign" attribute has been set,
   * otherwise @c false is returned.
   */
  virtual bool isSetSign() const;


  /**
   * Predicate returning @c true or @c false depending on whether this
   * Input's "thresholdLevel" attribute has been set.
   *
   * @return @c true if this Input's "thresholdLevel" attribute has been set,
   * otherwise @c false is returned.
   */
  virtual bool isSetThresholdLevel() const;


  /**
   * Sets the value of the "id" attribute of this Input.
   *
   * @param id const std::string& value of the "id" attribute to be set
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */
  virtual int setId(const std::string& id);


  /**
   * Sets the value of the "qualitativeSpecies" attribute of this Input.
   *
   * @param qualitativeSpecies const std::string& value of the "qualitativeSpecies" attribute to be set
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */
  virtual int setQualitativeSpecies(const std::string& qualitativeSpecies);


  /**
   * Sets the value of the "transitionEffect" attribute of this Input.
   *
   * @param transitionEffect const std::string& value of the "transitionEffect" attribute to be set
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */
  int setTransitionEffect(const InputTransitionEffect_t transitionEffect);


  /**
   * Sets the value of the "name" attribute of this Input.
   *
   * @param name const std::string& value of the "name" attribute to be set
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */
  virtual int setName(const std::string& name);


  /**
   * Sets the value of the "sign" attribute of this Input.
   *
   * @param sign const std::string& value of the "sign" attribute to be set
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */
  int setSign(const InputSign_t sign);


  /**
   * Sets the value of the "thresholdLevel" attribute of this Input.
   *
   * @param thresholdLevel int value of the "thresholdLevel" attribute to be set
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE @endlink
   */
  virtual int setThresholdLevel(int thresholdLevel);


  /**
   * Unsets the value of the "id" attribute of this Input.
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */
  virtual int unsetId();


  /**
   * Unsets the value of the "qualitativeSpecies" attribute of this Input.
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */
  virtual int unsetQualitativeSpecies();


  /**
   * Unsets the value of the "transitionEffect" attribute of this Input.
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */
  int unsetTransitionEffect();


  /**
   * Unsets the value of the "name" attribute of this Input.
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */
  virtual int unsetName();


  /**
   * Unsets the value of the "sign" attribute of this Input.
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */
  virtual int unsetSign();


  /**
   * Unsets the value of the "thresholdLevel" attribute of this Input.
   *
   * @return integer value indicating success/failure of the
   * operation. The possible return values are:
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS @endlink
   * @li @link OperationReturnValues_t#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED @endlink
   */
  virtual int unsetThresholdLevel();


  /**
   * Renames all the @c SIdRef attributes on this element, including any
   * found in MathML content (if such exists).
   *
   * This method works by looking at all attributes and (if appropriate)
   * mathematical formulas, comparing the identifiers to the value of @p
   * oldid.  If any matches are found, the matching identifiers are replaced
   * with @p newid.  The method does @em not descend into child elements.
   *
   * @param oldid the old identifier
   * @param newid the new identifier
   */
   virtual void renameSIdRefs(const std::string& oldid, const std::string& newid);


  /**
   * Returns the XML element name of this object, which for Input, is
   * always @c "input".
   *
   * @return the name of this element, i.e. @c "input".
   */
  virtual const std::string& getElementName () const;


  /**
   * Returns the libSBML type code of this object instance.
   *
   * @copydetails doc_what_are_typecodes
   *
   * @return the SBML type code for this object:
   * @link SBMLQualTypeCode_t#SBML_QUAL_INPUT SBML_QUAL_INPUT@endlink
   *
   * @copydetails doc_warning_typecodes_not_unique
   *
   * @see getElementName()
   * @see getPackageName()
   */
  virtual int getTypeCode () const;


  /**
   * Predicate returning @c true if all the required attributes
   * for this Input object have been set.
   *
   * @note The required attributes for a Input object are:
   * @li "qualitativeSpecies"
   * @li "transitionEffect"
   *
   * @return a boolean value indicating whether all the required
   * attributes for this object have been defined.
   */
  virtual bool hasRequiredAttributes() const;


  /** @cond doxygenLibsbmlInternal */

  /**
   * Subclasses should override this method to write out their contained
   * SBML objects as XML elements.  Be sure to call your parents
   * implementation of this method as well.
   */
  virtual void writeElements (XMLOutputStream& stream) const;


  /** @endcond */


  /** @cond doxygenLibsbmlInternal */

  /**
   * Accepts the given SBMLVisitor.
   */
  virtual bool accept (SBMLVisitor& v) const;


  /** @endcond */


  /** @cond doxygenLibsbmlInternal */

  /**
   * Sets the parent SBMLDocument.
   */
  virtual void setSBMLDocument (SBMLDocument* d);


  /** @endcond */


  /** @cond doxygenLibsbmlInternal */

  /**
   * Enables/Disables the given package with this element.
   */
  virtual void enablePackageInternal(const std::string& pkgURI,
               const std::string& pkgPrefix, bool flag);


  /** @endcond */


protected:

  /** @cond doxygenLibsbmlInternal */

  /**
   * Get the list of expected attributes for this element.
   */
  virtual void addExpectedAttributes(ExpectedAttributes& attributes);


  /** @endcond */


  /** @cond doxygenLibsbmlInternal */

  /**
   * Read values from the given XMLAttributes set into their specific fields.
   */
  virtual void readAttributes (const XMLAttributes& attributes,
                               const ExpectedAttributes& expectedAttributes);


  /** @endcond */


  /** @cond doxygenLibsbmlInternal */

  /**
   * Write values of XMLAttributes to the output stream.
   */
  virtual void writeAttributes (XMLOutputStream& stream) const;


  /** @endcond */



};

/**
 * @class ListOfInputs
 * @sbmlbrief{qual} Implementation of the %ListOfInputs construct from the
 * 'qual' package.
 * 
 * The ListOfInputs is a container for the Inputs of a Transition.
 * 
 * @copydetails doc_what_is_listof
 *
 * @see Input
 */
class LIBSBML_EXTERN ListOfInputs : public ListOf
{

public:

  /**
   * Creates a new ListOfInputs with the given level, version, and package version.
   *
   * @param level an unsigned int, the SBML Level to assign to this ListOfInputs
   *
   * @param version an unsigned int, the SBML Version to assign to this ListOfInputs
   *
   * @param pkgVersion an unsigned int, the SBML Qual Version to assign to this ListOfInputs
   */
  ListOfInputs(unsigned int level      = QualExtension::getDefaultLevel(),
               unsigned int version    = QualExtension::getDefaultVersion(),
               unsigned int pkgVersion = QualExtension::getDefaultPackageVersion());


  /**
   * Creates a new ListOfInputs with the given QualPkgNamespaces object.
   *
   * @param qualns the QualPkgNamespaces object
   */
  ListOfInputs(QualPkgNamespaces* qualns);


  /**
   * Creates and returns a deep copy of this ListOfInputs object.
   *
   * @return a (deep) copy of this ListOfInputs object.
   */
  virtual ListOfInputs* clone () const;


  /**
   * Get a Input from the ListOfInputs.
   *
   * @param n the index number of the Input to get.
   *
   * @return the nth Input in this ListOfInputs.
   *
   * @see size()
   */
  virtual Input* get(unsigned int n);


  /**
   * Get a Input from the ListOfInputs.
   *
   * @param n the index number of the Input to get.
   *
   * @return the nth Input in this ListOfInputs.
   *
   * @see size()
   */
  virtual const Input* get(unsigned int n) const;


  /**
   * Get a Input from the ListOfInputs
   * based on its identifier.
   *
   * @param sid a string representing the identifier
   * of the Input to get.
   *
   * @return Input in this ListOfInputs
   * with the given id or NULL if no such
   * Input exists.
   *
   * @see get(unsigned int n)   *
   * @see size()
   */
  virtual Input* get(const std::string& sid);


  /**
   * Get a Input from the ListOfInputs
   * based on its identifier.
   *
   * @param sid a string representing the identifier
   * of the Input to get.
   *
   * @return Input in this ListOfInputs
   * with the given id or NULL if no such
   * Input exists.
   *
   * @see get(unsigned int n)   *
   * @see size()
   */
  virtual const Input* get(const std::string& sid) const;


  /**
   * Get a Input from the ListOfInputs
   * based on the qualitativeSpecies to which it refers.
   *
   * @param sid a string representing the qualitativeSpecies attribute
   * of the Input to get.
   *
   * @return the first Input in this ListOfInputs
   * with the given qualitativeSpecies or NULL if no such
   * Input exists.
   *
   * @see get(unsigned int n)   *
   * @see size()
   */
  const Input* getBySpecies(const std::string& sid) const;


  /**
   * Get a Input from the ListOfInputs
   * based on the qualitativeSpecies to which it refers.
   *
   * @param sid a string representing the qualitativeSpecies attribute
   * of the Input to get.
   *
   * @return the first Input in this ListOfInputs
   * with the given qualitativeSpecies or NULL if no such
   * Input exists.
   *
   * @see get(unsigned int n)   *
   * @see size()
   */
  Input* getBySpecies(const std::string& sid);


  /**
   * Removes the nth Input from this ListOfInputs
   * and returns a pointer to it.
   *
   * The caller owns the returned item and is responsible for deleting it.
   *
   * @param n the index of the Input to remove.
   *
   * @see size()
   */
  virtual Input* remove(unsigned int n);


  /**
   * Removes the Input from this ListOfInputs with the given identifier
   * and returns a pointer to it.
   *
   * The caller owns the returned item and is responsible for deleting it.
   * If none of the items in this list have the identifier @p sid, then
   * @c NULL is returned.
   *
   * @param sid the identifier of the Input to remove.
   *
   * @return the Input removed. As mentioned above, the caller owns the
   * returned item.
   */
  virtual Input* remove(const std::string& sid);


  /**
   * Returns the XML element name of this object, which for ListOfInputs, is
   * always @c "listOfInputs".
   *
   * @return the name of this element, i.e. @c "listOfInputs".
   */
  virtual const std::string& getElementName () const;


  /**
   * Returns the libSBML type code for the SBML objects
   * contained in this ListOf object.
   * 
   * @copydetails doc_what_are_typecodes
   *
   * @return the SBML type code for objects contained in this list:
   * @link SBMLTypeCode_t#SBML_QUAL_INPUT SBML_QUAL_INPUT@endlink (default).
   *
   * @see getElementName()
   * @see getPackageName()
   */
  virtual int getItemTypeCode () const;


protected:

  /** @cond doxygenLibsbmlInternal */

  /**
   * Creates a new Input in this ListOfInputs
   */
  virtual SBase* createObject(XMLInputStream& stream);


  /** @endcond */


  /** @cond doxygenLibsbmlInternal */

  /**
   * Write the namespace for the Qual package.
   */
  virtual void writeXMLNS(XMLOutputStream& stream) const;


  /** @endcond */



};



LIBSBML_CPP_NAMESPACE_END

#endif  /*  __cplusplus  */

#ifndef SWIG

LIBSBML_CPP_NAMESPACE_BEGIN
BEGIN_C_DECLS

LIBSBML_EXTERN
Input_t *
Input_create(unsigned int level, unsigned int version,
             unsigned int pkgVersion);


LIBSBML_EXTERN
void
Input_free(Input_t * i);


LIBSBML_EXTERN
Input_t *
Input_clone(Input_t * i);


LIBSBML_EXTERN
char *
Input_getId(Input_t * i);


LIBSBML_EXTERN
char *
Input_getQualitativeSpecies(Input_t * i);


LIBSBML_EXTERN
InputTransitionEffect_t
Input_getTransitionEffect(Input_t * i);


LIBSBML_EXTERN
char *
Input_getName(Input_t * i);


LIBSBML_EXTERN
InputSign_t
Input_getSign(Input_t * i);


LIBSBML_EXTERN
int
Input_getThresholdLevel(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetId(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetQualitativeSpecies(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetTransitionEffect(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetName(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetSign(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetThresholdLevel(Input_t * i);


LIBSBML_EXTERN
int
Input_setId(Input_t * i, const char * id);


LIBSBML_EXTERN
int
Input_setQualitativeSpecies(Input_t * i, const char * qualitativeSpecies);


LIBSBML_EXTERN
int
Input_setTransitionEffect(Input_t * i, InputTransitionEffect_t transitionEffect);


LIBSBML_EXTERN
int
Input_setName(Input_t * i, const char * name);


LIBSBML_EXTERN
int
Input_setSign(Input_t * i, InputSign_t sign);


LIBSBML_EXTERN
int
Input_setThresholdLevel(Input_t * i, int thresholdLevel);


LIBSBML_EXTERN
int
Input_unsetId(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetQualitativeSpecies(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetTransitionEffect(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetName(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetSign(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetThresholdLevel(Input_t * i);


LIBSBML_EXTERN
int
Input_hasRequiredAttributes(Input_t * i);


LIBSBML_EXTERN
Input_t *
ListOfInputs_getById(ListOf_t * lo, const char * sid);


LIBSBML_EXTERN
Input_t *
ListOfInputs_removeById(ListOf_t * lo, const char * sid);


LIBSBML_EXTERN
const char* 
InputTransitionEffect_toString(InputTransitionEffect_t effect);


LIBSBML_EXTERN
InputTransitionEffect_t 
InputTransitionEffect_fromString(const char* s);


LIBSBML_EXTERN
int 
InputTransitionEffect_isValidInputTransitionEffect(InputTransitionEffect_t effect);


LIBSBML_EXTERN
int 
InputTransitionEffect_isValidInputTransitionEffectString(const char* s);


LIBSBML_EXTERN
const char* 
InputSign_toString(InputSign_t effect);

LIBSBML_EXTERN
InputSign_t 
InputSign_fromString(const char* s);


LIBSBML_EXTERN
int 
InputSign_isValidInputSign(InputSign_t effect);


LIBSBML_EXTERN
int 
InputSign_isValidInputSignString(const char* s);


END_C_DECLS
LIBSBML_CPP_NAMESPACE_END

#endif  /*  !SWIG  */

#endif /*  Input_H__  */
