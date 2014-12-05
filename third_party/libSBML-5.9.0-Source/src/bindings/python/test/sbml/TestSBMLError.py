#
# @file    TestSBMLError.py
# @brief   SBMLError unit tests, C++ version
#
# @author  Akiya Jouraku (Python conversion)
# @author  Sarah Keating 
# 
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestSBMLError.cpp
# using the conversion program dev/utilities/translateTests/translateTests.pl.
# Any changes made here will be lost the next time the file is regenerated.
#
# -----------------------------------------------------------------------------
# This file is part of libSBML.  Please visit http://sbml.org for more
# information about SBML, and the latest version of libSBML.
#
# Copyright 2005-2010 California Institute of Technology.
# Copyright 2002-2005 California Institute of Technology and
#                     Japan Science and Technology Corporation.
# 
# This library is free software; you can redistribute it and/or modify it
# under the terms of the GNU Lesser General Public License as published by
# the Free Software Foundation.  A copy of the license agreement is provided
# in the file named "LICENSE.txt" included with this software distribution
# and also available online as http://sbml.org/software/libsbml/license.html
# -----------------------------------------------------------------------------

import sys
import unittest
import libsbml


class TestSBMLError(unittest.TestCase):


  def test_SBMLError_create(self):
    error = libsbml.SBMLError()
    self.assert_( error != None )
    error = None
    error = libsbml.SBMLError(libsbml.EmptyListInReaction)
    self.assert_( error.getErrorId() == libsbml.EmptyListInReaction )
    self.assert_( error.getSeverity() == libsbml.LIBSBML_SEV_ERROR )
    self.assert_( error.getSeverityAsString() ==  "Error"  )
    self.assert_( error.getCategory() == libsbml.LIBSBML_CAT_SBML )
    self.assert_( error.getCategoryAsString() ==  "General SBML conformance" )
    error = None
    error = libsbml.SBMLError(libsbml.OverdeterminedSystem,2,1)
    self.assert_( error.getErrorId() == libsbml.OverdeterminedSystem )
    self.assert_( error.getSeverity() == libsbml.LIBSBML_SEV_WARNING )
    self.assert_( error.getSeverityAsString() ==  "Warning"  )
    self.assert_( error.getCategory() == libsbml.LIBSBML_CAT_SBML )
    self.assert_( error.getCategoryAsString() ==  "General SBML conformance" )
    error = None
    error = libsbml.SBMLError(libsbml.OffsetNoLongerValid,2,2)
    self.assert_( error.getErrorId() == libsbml.OffsetNoLongerValid )
    self.assert_( error.getSeverity() == libsbml.LIBSBML_SEV_ERROR )
    self.assert_( error.getSeverityAsString() ==  "Error"  )
    self.assert_( error.getCategory() == libsbml.LIBSBML_CAT_GENERAL_CONSISTENCY )
    self.assert_( error.getCategoryAsString() ==  "SBML component consistency" )
    error = None
    error = libsbml.SBMLError(libsbml.NoSBOTermsInL1,2,2)
    self.assert_( error.getErrorId() == libsbml.NoSBOTermsInL1 )
    self.assert_( error.getSeverity() == libsbml.LIBSBML_SEV_WARNING )
    self.assert_( error.getSeverityAsString() ==  "Warning"  )
    self.assert_( error.getCategory() == libsbml.LIBSBML_CAT_SBML_L1_COMPAT )
    self.assert_( error.getCategoryAsString() ==  "Translation to SBML L1V2" )
    error = None
    error = libsbml.SBMLError(libsbml.DisallowedMathMLEncodingUse,2,2)
    self.assert_( error.getErrorId() == libsbml.DisallowedMathMLEncodingUse )
    self.assert_( error.getSeverity() == libsbml.LIBSBML_SEV_ERROR )
    self.assert_( error.getSeverityAsString() ==  "Error"  )
    self.assert_( error.getCategory() == libsbml.LIBSBML_CAT_MATHML_CONSISTENCY )
    self.assert_( error.getShortMessage() ==  "Use of the MathML 'encoding' attribute is not allowed on this element" )
    error = None
    error = libsbml.SBMLError(libsbml.DisallowedMathMLEncodingUse,1,2)
    self.assert_( error.getErrorId() == libsbml.DisallowedMathMLEncodingUse )
    self.assert_( error.getSeverity() == libsbml.LIBSBML_SEV_NOT_APPLICABLE )
    self.assert_( error.getCategory() == libsbml.LIBSBML_CAT_MATHML_CONSISTENCY )
    error = None
    error = libsbml.SBMLError(libsbml.UnknownError,2,4)
    self.assert_( error.getErrorId() == libsbml.UnknownError )
    self.assert_( error.getSeverity() == libsbml.LIBSBML_SEV_FATAL )
    self.assert_( error.getSeverityAsString() ==  "Fatal"  )
    self.assert_( error.getCategory() == libsbml.LIBSBML_CAT_INTERNAL )
    self.assert_( error.getShortMessage() ==  "Encountered unknown internal libSBML error" )
    error = None
    pass  

def suite():
  suite = unittest.TestSuite()
  suite.addTest(unittest.makeSuite(TestSBMLError))

  return suite

if __name__ == "__main__":
  if unittest.TextTestRunner(verbosity=1).run(suite()).wasSuccessful() :
    sys.exit(0)
  else:
    sys.exit(1)