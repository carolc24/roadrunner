# == PREAMBLE ================================================
# * Licensed under the Apache License, Version 2.0; see README

# == FILEDOC =================================================

# @file autotest/CMakeLists.txt
# @author JKM(0u812)
# @date 07/01/2015
# @copyright Apache License, Version 2.0
# @brief Automated unit tests

if(BUILD_PYTHON)
  file(COPY python-benchmark-bioinf DESTINATION .)

  # update when source changes
  configure_file(python-benchmark-bioinf/rr_bench_ode.py
    ${CMAKE_CURRENT_BINARY_DIR}/python-benchmark-bioinf/rr_bench_ode.py COPYONLY)

  add_test(NAME PythonBenchmarkODEBioinf2015
    COMMAND ${PYTHON_EXECUTABLE} rr_bench_ode.py
    WORKING_DIRECTORY ${CMAKE_CURRENT_BINARY_DIR}/python-benchmark-bioinf)
  set_tests_properties(PythonBenchmarkODEBioinf2015 PROPERTIES ENVIRONMENT "PYTHONPATH=${CMAKE_BINARY_DIR}/lib/site-packages:$PYTHONPATH")
  message(STATUS "CTest: PYTHONPATH=${CMAKE_BINARY_DIR}/lib/site-packages:$PYTHONPATH")
endif()