set(TESTSOURCES
  loadlibrarya.cpp
)

add_executable(paltest_loadlibrarya_test8
  ${TESTSOURCES}
)

add_dependencies(paltest_loadlibrarya_test8 coreclrpal)

target_link_libraries(paltest_loadlibrarya_test8
  ${COMMON_TEST_LIBRARIES}
)


set(HELPERSOURCES
  dlltest.cpp
)

add_executable(paltest_loadlibrarya_test8_dlltest
  ${HELPERSOURCES}
)

add_dependencies(paltest_loadlibrarya_test8_dlltest coreclrpal)

target_link_libraries(paltest_loadlibrarya_test8_dlltest
  ${COMMON_TEST_LIBRARIES}
)
