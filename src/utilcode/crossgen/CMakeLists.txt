include(${CLR_DIR}/crossgen.cmake)

add_precompiled_header(stdafx.h ../stdafx.cpp UTILCODE_CROSSGEN_SOURCES)
add_library(utilcode_crossgen STATIC ${UTILCODE_CROSSGEN_SOURCES})
if(CLR_CMAKE_PLATFORM_UNIX)
  target_link_libraries(utilcode_crossgen  nativeresourcestring)
endif(CLR_CMAKE_PLATFORM_UNIX)
