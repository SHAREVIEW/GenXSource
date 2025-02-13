#!/usr/bin/env python
#******************************************************************************
#  $Id: gdalchksum.py 7210 2005-02-23 14:37:03Z fwarmerdam $
# 
#  Project:  GDAL
#  Purpose:  Application to checksum a GDAL image file.
#  Author:   Frank Warmerdam, warmerdam@pobox.com
# 
#******************************************************************************
#  Copyright (c) 2003, Frank Warmerdam <warmerdam@pobox.com>
# 
#  Permission is hereby granted, free of charge, to any person obtaining a
#  copy of this software and associated documentation files (the "Software"),
#  to deal in the Software without restriction, including without limitation
#  the rights to use, copy, modify, merge, publish, distribute, sublicense,
#  and/or sell copies of the Software, and to permit persons to whom the
#  Software is furnished to do so, subject to the following conditions:
# 
#  The above copyright notice and this permission notice shall be included
#  in all copies or substantial portions of the Software.
# 
#  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
#  OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
#  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
#  THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
#  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
#  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
#  DEALINGS IN THE SOFTWARE.
#******************************************************************************
# 
# $Log$
# Revision 1.3  2005/02/23 14:37:03  fwarmerdam
# fixed band selection logic
#
# Revision 1.2  2004/04/02 17:40:44  warmerda
# added GDALGeneralCmdLineProcessor() support
#
# Revision 1.1  2003/03/02 17:11:33  warmerda
# New
#
#

import gdal
import sys

def Usage():
    print 'Usage: gdalchksum.py [-b band] [-srcwin xoff yoff xsize ysize] file'
    sys.exit(1)

# =============================================================================
# 	Mainline
# =============================================================================

srcwin = None
bands = []

filename = None

gdal.AllRegister()
argv = gdal.GeneralCmdLineProcessor( sys.argv )
if argv is None:
    sys.exit( 0 )

# Parse command line arguments.
i = 1
while i < len(argv):
    arg = argv[i]

    if arg == '-b':
        i = i + 1
        bands.append( int(argv[i]) )

    elif arg == '-srcwin':
        srcwin = [int(argv[i+1]),int(argv[i+2]),
                  int(argv[i+3]),int(argv[i+3]) ]
        i = i + 4

    elif filename is None:
        filename = argv[i]

    else:
        Usage()

    i = i + 1

if filename is None:
    Usage()
    
# Open source file

ds = gdal.Open( filename )
if ds is None:
    print 'Unable to open ', filename
    sys.exit(1)

# Default values

if srcwin is None:
    srcwin = [ 0, 0, ds.RasterXSize, ds.RasterYSize ]

if len(bands) == 0:
    bands = range(1,(ds.RasterCount+1))


# Generate checksums

for band_num in bands:
    oBand = ds.GetRasterBand( band_num )
    result = oBand.Checksum( srcwin[0], srcwin[1], srcwin[2], srcwin[3] )
    print result

ds = None








