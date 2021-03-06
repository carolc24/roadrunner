# @file    TestL3KineticLaw.rb
# @brief   L3 KineticLaw unit tests
#
# @author  Akiya Jouraku (Ruby conversion)
# @author  Sarah Keating 
#
#
# ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
#
# DO NOT EDIT THIS FILE.
#
# This file was generated automatically by converting the file located at
# src/sbml/test/TestL3KineticLaw.c
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
require 'test/unit'
require 'libSBML'

class TestL3KineticLaw < Test::Unit::TestCase

  def setup
    @@kl = LibSBML::KineticLaw.new(3,1)
    if (@@kl == nil)
    end
  end

  def teardown
    @@kl = nil
  end

  def test_L3_KineticLaw_addParameter1
    kl = LibSBML::KineticLaw.new(3,1)
    p = LibSBML::Parameter.new(3,1)
    i = @@kl.addParameter(p)
    assert( i == LibSBML::LIBSBML_INVALID_OBJECT )
    p.setId( "p")
    i = @@kl.addParameter(p)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( @@kl.getNumParameters() == 1 )
    assert( @@kl.getNumLocalParameters() == 1 )
    assert( kl.getNumParameters() == 0 )
    assert( kl.getNumLocalParameters() == 0 )
    i = kl.addParameter(p)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( @@kl.getNumParameters() == 1 )
    assert( @@kl.getNumLocalParameters() == 1 )
    assert( kl.getNumParameters() == 1 )
    assert( kl.getNumLocalParameters() == 1 )
    p = nil
    kl = nil
  end

  def test_L3_KineticLaw_addParameter2
    kl = LibSBML::KineticLaw.new(3,1)
    lp = LibSBML::LocalParameter.new(3,1)
    lp1 = LibSBML::LocalParameter.new(3,1)
    i = kl.addLocalParameter(lp)
    assert( i == LibSBML::LIBSBML_INVALID_OBJECT )
    lp.setId( "p")
    lp1.setId("p1")
    i = kl.addLocalParameter(lp)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( kl.getNumParameters() == 1 )
    assert( kl.getNumLocalParameters() == 1 )
    i = kl.addParameter(lp1)
    assert( i == LibSBML::LIBSBML_OPERATION_SUCCESS )
    assert( kl.getNumParameters() == 2 )
    assert( kl.getNumLocalParameters() == 2 )
    lp = nil
    kl = nil
  end

  def test_L3_KineticLaw_create
    assert( @@kl.getTypeCode() == LibSBML::SBML_KINETIC_LAW )
    assert( @@kl.getMetaId() == "" )
    assert( @@kl.getNotes() == nil )
    assert( @@kl.getAnnotation() == nil )
    assert( @@kl.getNumParameters() == 0 )
    assert( @@kl.getNumLocalParameters() == 0 )
  end

  def test_L3_KineticLaw_free_NULL
  end

end
