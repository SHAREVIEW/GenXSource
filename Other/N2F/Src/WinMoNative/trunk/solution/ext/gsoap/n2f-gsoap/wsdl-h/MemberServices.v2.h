namespace WS_MemberServices_v2 {


/* .\wsdl-h\MemberServices.v2.h
   Generated by wsdl2h 1.2.10 from .\wsdl\MemberServices.v2.wsdl and typemap.dat
   2008-04-15 20:07:34 GMT
   Copyright (C) 2001-2008 Robert van Engelen, Genivia Inc. All Rights Reserved.
   This part of the software is released under one of the following licenses:
   GPL or Genivia's license for commercial use.
*/

/* NOTE:

 - Compile this file with soapcpp2 to complete the code generation process.
 - Use soapcpp2 option -I to specify paths for #import
   To build with STL, 'stlvector.h' is imported from 'import' dir in package.
 - Use wsdl2h options -c and -s to generate pure C code or C++ code without STL.
 - Use 'WS/typemap.dat' to control namespace bindings and type mappings.
   It is strongly recommended to customize the names of the namespace prefixes
   generated by wsdl2h. To do so, modify the prefix bindings in the Namespaces
   section below and add the modified lines to 'typemap.dat' to rerun wsdl2h.
 - Use Doxygen (www.doxygen.org) to browse this file.
 - Use wsdl2h option -l to view the software license terms.

   DO NOT include this file directly into your project.
   Include only the soapcpp2-generated headers and source code files.
*/

//gsoapopt w

/******************************************************************************\
 *                                                                            *
 * http://tempuri.org/                                                        *
 *                                                                            *
\******************************************************************************/


/******************************************************************************\
 *                                                                            *
 * Import                                                                     *
 *                                                                            *
\******************************************************************************/


// STL vector containers (use option -s to disable)
#import ".\..\gsoap-2.7.10\gsoap\import/stlvector.h"

/******************************************************************************\
 *                                                                            *
 * Schema Namespaces                                                          *
 *                                                                            *
\******************************************************************************/


/* NOTE:

It is strongly recommended to customize the names of the namespace prefixes
generated by wsdl2h. To do so, modify the prefix bindings below and add the
modified lines to typemap.dat to rerun wsdl2h:

MemberServicesV2 = "http://tempuri.org/"

*/

//gsoap MemberServicesV2 schema namespace:	http://tempuri.org/
//gsoap MemberServicesV2 schema elementForm:	qualified
//gsoap MemberServicesV2 schema attributeForm:	unqualified

/******************************************************************************\
 *                                                                            *
 * Schema Types                                                               *
 *                                                                            *
\******************************************************************************/



//  Forward declaration of class _MemberServicesV2__GetEncryptionKey.
class _MemberServicesV2__GetEncryptionKey;

//  Forward declaration of class _MemberServicesV2__GetEncryptionKeyResponse.
class _MemberServicesV2__GetEncryptionKeyResponse;

//  Forward declaration of class _MemberServicesV2__GetMemberID.
class _MemberServicesV2__GetMemberID;

//  Forward declaration of class _MemberServicesV2__GetMemberIDResponse.
class _MemberServicesV2__GetMemberIDResponse;

//  Forward declaration of class _MemberServicesV2__GetTagID.
class _MemberServicesV2__GetTagID;

//  Forward declaration of class _MemberServicesV2__GetTagIDResponse.
class _MemberServicesV2__GetTagIDResponse;


/// Element "http://tempuri.org/":GetEncryptionKey of complexType.

/// "http://tempuri.org/":GetEncryptionKey is a complexType.
class _MemberServicesV2__GetEncryptionKey
{ public:
/// Element WebMemberID of type xs:string.
    std::string*                         WebMemberID                    0;	///< Optional element.
/// Element WebPassword of type xs:string.
    std::string*                         WebPassword                    0;	///< Optional element.
/// A handle to the soap struct that manages this instance (automatically set)
    struct soap                         *soap                          ;
};


/// Element "http://tempuri.org/":GetEncryptionKeyResponse of complexType.

/// "http://tempuri.org/":GetEncryptionKeyResponse is a complexType.
class _MemberServicesV2__GetEncryptionKeyResponse
{ public:
/// Element GetEncryptionKeyResult of type xs:string.
    std::string*                         GetEncryptionKeyResult         0;	///< Optional element.
/// A handle to the soap struct that manages this instance (automatically set)
    struct soap                         *soap                          ;
};


/// Element "http://tempuri.org/":GetMemberID of complexType.

/// "http://tempuri.org/":GetMemberID is a complexType.
class _MemberServicesV2__GetMemberID
{ public:
/// Element NickName of type xs:string.
    std::string*                         NickName                       0;	///< Optional element.
/// Element WebPassword of type xs:string.
    std::string*                         WebPassword                    0;	///< Optional element.
/// A handle to the soap struct that manages this instance (automatically set)
    struct soap                         *soap                          ;
};


/// Element "http://tempuri.org/":GetMemberIDResponse of complexType.

/// "http://tempuri.org/":GetMemberIDResponse is a complexType.
class _MemberServicesV2__GetMemberIDResponse
{ public:
/// Element GetMemberIDResult of type xs:string.
    std::string*                         GetMemberIDResult              0;	///< Optional element.
/// A handle to the soap struct that manages this instance (automatically set)
    struct soap                         *soap                          ;
};


/// Element "http://tempuri.org/":GetTagID of complexType.

/// "http://tempuri.org/":GetTagID is a complexType.
class _MemberServicesV2__GetTagID
{ public:
/// Element WebMemberID of type xs:string.
    std::string*                         WebMemberID                    0;	///< Optional element.
/// Element WebPassword of type xs:string.
    std::string*                         WebPassword                    0;	///< Optional element.
/// A handle to the soap struct that manages this instance (automatically set)
    struct soap                         *soap                          ;
};


/// Element "http://tempuri.org/":GetTagIDResponse of complexType.

/// "http://tempuri.org/":GetTagIDResponse is a complexType.
class _MemberServicesV2__GetTagIDResponse
{ public:
/// Element GetTagIDResult of type xs:string.
    std::string*                         GetTagIDResult                 0;	///< Optional element.
/// A handle to the soap struct that manages this instance (automatically set)
    struct soap                         *soap                          ;
};

/// Element "http://tempuri.org/":string of type xs:string.
/// Note: use wsdl2h option -g to generate this global element declaration.

/******************************************************************************\
 *                                                                            *
 * Services                                                                   *
 *                                                                            *
\******************************************************************************/


//gsoap MemberServicesV22 service name:	MemberServicesSoap 
//gsoap MemberServicesV22 service type:	MemberServicesSoap 
//gsoap MemberServicesV22 service port:	http://services.next2friends.com/n2fwebservices/memberservices.asmx 
//gsoap MemberServicesV22 service namespace:	http://tempuri.org/MemberServicesSoap 
//gsoap MemberServicesV22 service transport:	http://schemas.xmlsoap.org/soap/http 

//gsoap MemberServicesV23 service name:	MemberServicesSoap12 
//gsoap MemberServicesV23 service type:	MemberServicesSoap 
//gsoap MemberServicesV23 service port:	http://services.next2friends.com/n2fwebservices/memberservices.asmx 
//gsoap MemberServicesV23 service namespace:	http://tempuri.org/MemberServicesSoap12 
//gsoap MemberServicesV23 service transport:	http://schemas.xmlsoap.org/soap/http 

/** @mainpage Service Definitions

@section Service_bindings Bindings
  - @ref MemberServicesSoap
  - @ref MemberServicesSoap12

*/

/**

@page MemberServicesSoap Binding "MemberServicesSoap"

@section MemberServicesSoap_operations Operations of Binding  "MemberServicesSoap"
  - @ref __MemberServicesV22__GetEncryptionKey
  - @ref __MemberServicesV22__GetMemberID
  - @ref __MemberServicesV22__GetTagID

@section MemberServicesSoap_ports Endpoints of Binding  "MemberServicesSoap"
  - http://services.next2friends.com/n2fwebservices/memberservices.asmx

Note: use wsdl2h option -N to change the service binding prefix name

*/

/**

@page MemberServicesSoap12 Binding "MemberServicesSoap12"

@section MemberServicesSoap12_operations Operations of Binding  "MemberServicesSoap12"
  - @ref __MemberServicesV23__GetEncryptionKey
  - @ref __MemberServicesV23__GetMemberID
  - @ref __MemberServicesV23__GetTagID

@section MemberServicesSoap12_ports Endpoints of Binding  "MemberServicesSoap12"
  - http://services.next2friends.com/n2fwebservices/memberservices.asmx

Note: use wsdl2h option -N to change the service binding prefix name

*/

/******************************************************************************\
 *                                                                            *
 * MemberServicesSoap                                                         *
 *                                                                            *
\******************************************************************************/


/******************************************************************************\
 *                                                                            *
 * __MemberServicesV22__GetEncryptionKey                                      *
 *                                                                            *
\******************************************************************************/


/// Operation "__MemberServicesV22__GetEncryptionKey" of service binding "MemberServicesSoap"

/**

Operation details:

  - SOAP document/literal style
  - SOAP action="http://tempuri.org/GetEncryptionKey"

C stub function (defined in soapClient.c[pp] generated by soapcpp2):
@code
  int soap_call___MemberServicesV22__GetEncryptionKey(
    struct soap *soap,
    NULL, // char *endpoint = NULL selects default endpoint for this operation
    NULL, // char *action = NULL selects default action for this operation
    // request parameters:
    _MemberServicesV2__GetEncryptionKey* MemberServicesV2__GetEncryptionKey,
    // response parameters:
    _MemberServicesV2__GetEncryptionKeyResponse* MemberServicesV2__GetEncryptionKeyResponse
  );
@endcode

C server function (called from the service dispatcher defined in soapServer.c[pp]):
@code
  int __MemberServicesV22__GetEncryptionKey(
    struct soap *soap,
    // request parameters:
    _MemberServicesV2__GetEncryptionKey* MemberServicesV2__GetEncryptionKey,
    // response parameters:
    _MemberServicesV2__GetEncryptionKeyResponse* MemberServicesV2__GetEncryptionKeyResponse
  );
@endcode

C++ proxy class (defined in soapMemberServicesSoapProxy.h):
  class MemberServicesSoap;

Note: use soapcpp2 option '-i' to generate improved proxy and service classes;

*/

//gsoap MemberServicesV22 service method-style:	GetEncryptionKey document
//gsoap MemberServicesV22 service method-encoding:	GetEncryptionKey literal
//gsoap MemberServicesV22 service method-action:	GetEncryptionKey http://tempuri.org/GetEncryptionKey
int __MemberServicesV22__GetEncryptionKey(
    _MemberServicesV2__GetEncryptionKey* MemberServicesV2__GetEncryptionKey,	///< Request parameter
    _MemberServicesV2__GetEncryptionKeyResponse* MemberServicesV2__GetEncryptionKeyResponse	///< Response parameter
);

/******************************************************************************\
 *                                                                            *
 * __MemberServicesV22__GetMemberID                                           *
 *                                                                            *
\******************************************************************************/


/// Operation "__MemberServicesV22__GetMemberID" of service binding "MemberServicesSoap"

/**

Operation details:

  - SOAP document/literal style
  - SOAP action="http://tempuri.org/GetMemberID"

C stub function (defined in soapClient.c[pp] generated by soapcpp2):
@code
  int soap_call___MemberServicesV22__GetMemberID(
    struct soap *soap,
    NULL, // char *endpoint = NULL selects default endpoint for this operation
    NULL, // char *action = NULL selects default action for this operation
    // request parameters:
    _MemberServicesV2__GetMemberID*     MemberServicesV2__GetMemberID,
    // response parameters:
    _MemberServicesV2__GetMemberIDResponse* MemberServicesV2__GetMemberIDResponse
  );
@endcode

C server function (called from the service dispatcher defined in soapServer.c[pp]):
@code
  int __MemberServicesV22__GetMemberID(
    struct soap *soap,
    // request parameters:
    _MemberServicesV2__GetMemberID*     MemberServicesV2__GetMemberID,
    // response parameters:
    _MemberServicesV2__GetMemberIDResponse* MemberServicesV2__GetMemberIDResponse
  );
@endcode

C++ proxy class (defined in soapMemberServicesSoapProxy.h):
  class MemberServicesSoap;

Note: use soapcpp2 option '-i' to generate improved proxy and service classes;

*/

//gsoap MemberServicesV22 service method-style:	GetMemberID document
//gsoap MemberServicesV22 service method-encoding:	GetMemberID literal
//gsoap MemberServicesV22 service method-action:	GetMemberID http://tempuri.org/GetMemberID
int __MemberServicesV22__GetMemberID(
    _MemberServicesV2__GetMemberID*     MemberServicesV2__GetMemberID,	///< Request parameter
    _MemberServicesV2__GetMemberIDResponse* MemberServicesV2__GetMemberIDResponse	///< Response parameter
);

/******************************************************************************\
 *                                                                            *
 * __MemberServicesV22__GetTagID                                              *
 *                                                                            *
\******************************************************************************/


/// Operation "__MemberServicesV22__GetTagID" of service binding "MemberServicesSoap"

/**

Operation details:

  - SOAP document/literal style
  - SOAP action="http://tempuri.org/GetTagID"

C stub function (defined in soapClient.c[pp] generated by soapcpp2):
@code
  int soap_call___MemberServicesV22__GetTagID(
    struct soap *soap,
    NULL, // char *endpoint = NULL selects default endpoint for this operation
    NULL, // char *action = NULL selects default action for this operation
    // request parameters:
    _MemberServicesV2__GetTagID*        MemberServicesV2__GetTagID,
    // response parameters:
    _MemberServicesV2__GetTagIDResponse* MemberServicesV2__GetTagIDResponse
  );
@endcode

C server function (called from the service dispatcher defined in soapServer.c[pp]):
@code
  int __MemberServicesV22__GetTagID(
    struct soap *soap,
    // request parameters:
    _MemberServicesV2__GetTagID*        MemberServicesV2__GetTagID,
    // response parameters:
    _MemberServicesV2__GetTagIDResponse* MemberServicesV2__GetTagIDResponse
  );
@endcode

C++ proxy class (defined in soapMemberServicesSoapProxy.h):
  class MemberServicesSoap;

Note: use soapcpp2 option '-i' to generate improved proxy and service classes;

*/

//gsoap MemberServicesV22 service method-style:	GetTagID document
//gsoap MemberServicesV22 service method-encoding:	GetTagID literal
//gsoap MemberServicesV22 service method-action:	GetTagID http://tempuri.org/GetTagID
int __MemberServicesV22__GetTagID(
    _MemberServicesV2__GetTagID*        MemberServicesV2__GetTagID,	///< Request parameter
    _MemberServicesV2__GetTagIDResponse* MemberServicesV2__GetTagIDResponse	///< Response parameter
);

/******************************************************************************\
 *                                                                            *
 * MemberServicesSoap12                                                       *
 *                                                                            *
\******************************************************************************/


/******************************************************************************\
 *                                                                            *
 * __MemberServicesV23__GetEncryptionKey                                      *
 *                                                                            *
\******************************************************************************/


/// Operation "__MemberServicesV23__GetEncryptionKey" of service binding "MemberServicesSoap12"

/**

Operation details:

  - SOAP document/literal style
  - SOAP action="http://tempuri.org/GetEncryptionKey"

C stub function (defined in soapClient.c[pp] generated by soapcpp2):
@code
  int soap_call___MemberServicesV23__GetEncryptionKey(
    struct soap *soap,
    NULL, // char *endpoint = NULL selects default endpoint for this operation
    NULL, // char *action = NULL selects default action for this operation
    // request parameters:
    _MemberServicesV2__GetEncryptionKey* MemberServicesV2__GetEncryptionKey,
    // response parameters:
    _MemberServicesV2__GetEncryptionKeyResponse* MemberServicesV2__GetEncryptionKeyResponse
  );
@endcode

C server function (called from the service dispatcher defined in soapServer.c[pp]):
@code
  int __MemberServicesV23__GetEncryptionKey(
    struct soap *soap,
    // request parameters:
    _MemberServicesV2__GetEncryptionKey* MemberServicesV2__GetEncryptionKey,
    // response parameters:
    _MemberServicesV2__GetEncryptionKeyResponse* MemberServicesV2__GetEncryptionKeyResponse
  );
@endcode

C++ proxy class (defined in soapMemberServicesSoap12Proxy.h):
  class MemberServicesSoap12;

Note: use soapcpp2 option '-i' to generate improved proxy and service classes;

*/

//gsoap MemberServicesV23 service method-style:	GetEncryptionKey document
//gsoap MemberServicesV23 service method-encoding:	GetEncryptionKey literal
//gsoap MemberServicesV23 service method-action:	GetEncryptionKey http://tempuri.org/GetEncryptionKey
int __MemberServicesV23__GetEncryptionKey(
    _MemberServicesV2__GetEncryptionKey* MemberServicesV2__GetEncryptionKey,	///< Request parameter
    _MemberServicesV2__GetEncryptionKeyResponse* MemberServicesV2__GetEncryptionKeyResponse	///< Response parameter
);

/******************************************************************************\
 *                                                                            *
 * __MemberServicesV23__GetMemberID                                           *
 *                                                                            *
\******************************************************************************/


/// Operation "__MemberServicesV23__GetMemberID" of service binding "MemberServicesSoap12"

/**

Operation details:

  - SOAP document/literal style
  - SOAP action="http://tempuri.org/GetMemberID"

C stub function (defined in soapClient.c[pp] generated by soapcpp2):
@code
  int soap_call___MemberServicesV23__GetMemberID(
    struct soap *soap,
    NULL, // char *endpoint = NULL selects default endpoint for this operation
    NULL, // char *action = NULL selects default action for this operation
    // request parameters:
    _MemberServicesV2__GetMemberID*     MemberServicesV2__GetMemberID,
    // response parameters:
    _MemberServicesV2__GetMemberIDResponse* MemberServicesV2__GetMemberIDResponse
  );
@endcode

C server function (called from the service dispatcher defined in soapServer.c[pp]):
@code
  int __MemberServicesV23__GetMemberID(
    struct soap *soap,
    // request parameters:
    _MemberServicesV2__GetMemberID*     MemberServicesV2__GetMemberID,
    // response parameters:
    _MemberServicesV2__GetMemberIDResponse* MemberServicesV2__GetMemberIDResponse
  );
@endcode

C++ proxy class (defined in soapMemberServicesSoap12Proxy.h):
  class MemberServicesSoap12;

Note: use soapcpp2 option '-i' to generate improved proxy and service classes;

*/

//gsoap MemberServicesV23 service method-style:	GetMemberID document
//gsoap MemberServicesV23 service method-encoding:	GetMemberID literal
//gsoap MemberServicesV23 service method-action:	GetMemberID http://tempuri.org/GetMemberID
int __MemberServicesV23__GetMemberID(
    _MemberServicesV2__GetMemberID*     MemberServicesV2__GetMemberID,	///< Request parameter
    _MemberServicesV2__GetMemberIDResponse* MemberServicesV2__GetMemberIDResponse	///< Response parameter
);

/******************************************************************************\
 *                                                                            *
 * __MemberServicesV23__GetTagID                                              *
 *                                                                            *
\******************************************************************************/


/// Operation "__MemberServicesV23__GetTagID" of service binding "MemberServicesSoap12"

/**

Operation details:

  - SOAP document/literal style
  - SOAP action="http://tempuri.org/GetTagID"

C stub function (defined in soapClient.c[pp] generated by soapcpp2):
@code
  int soap_call___MemberServicesV23__GetTagID(
    struct soap *soap,
    NULL, // char *endpoint = NULL selects default endpoint for this operation
    NULL, // char *action = NULL selects default action for this operation
    // request parameters:
    _MemberServicesV2__GetTagID*        MemberServicesV2__GetTagID,
    // response parameters:
    _MemberServicesV2__GetTagIDResponse* MemberServicesV2__GetTagIDResponse
  );
@endcode

C server function (called from the service dispatcher defined in soapServer.c[pp]):
@code
  int __MemberServicesV23__GetTagID(
    struct soap *soap,
    // request parameters:
    _MemberServicesV2__GetTagID*        MemberServicesV2__GetTagID,
    // response parameters:
    _MemberServicesV2__GetTagIDResponse* MemberServicesV2__GetTagIDResponse
  );
@endcode

C++ proxy class (defined in soapMemberServicesSoap12Proxy.h):
  class MemberServicesSoap12;

Note: use soapcpp2 option '-i' to generate improved proxy and service classes;

*/

//gsoap MemberServicesV23 service method-style:	GetTagID document
//gsoap MemberServicesV23 service method-encoding:	GetTagID literal
//gsoap MemberServicesV23 service method-action:	GetTagID http://tempuri.org/GetTagID
int __MemberServicesV23__GetTagID(
    _MemberServicesV2__GetTagID*        MemberServicesV2__GetTagID,	///< Request parameter
    _MemberServicesV2__GetTagIDResponse* MemberServicesV2__GetTagIDResponse	///< Response parameter
);

/* End of .\wsdl-h\MemberServices.v2.h */

}	//namespace WS_MemberServices_v2
