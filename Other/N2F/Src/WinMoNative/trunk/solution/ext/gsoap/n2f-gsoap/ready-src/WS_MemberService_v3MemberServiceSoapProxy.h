/* WS_MemberService_v3MemberServiceSoapProxy.h
   Generated by gSOAP 2.7.10 from .\wsdl-h\MemberService.v3.h
   Copyright(C) 2000-2008, Robert van Engelen, Genivia Inc. All Rights Reserved.
   This part of the software is released under one of the following licenses:
   GPL, the gSOAP public license, or Genivia's license for commercial use.
*/

#ifndef WS_MemberService_v3MemberServiceSoapProxy_H
#define WS_MemberService_v3MemberServiceSoapProxy_H
#include "WS_MemberService_v3H.h"
extern SOAP_NMAC struct Namespace WS_MemberService_v3_namespaces[];

namespace WS_MemberService_v3 {
class MemberServiceSoap
{   public:
	/// Runtime engine context allocated in constructor
	struct soap *soap;
	/// Endpoint URL of service 'MemberServiceSoap' (change as needed)
	const char *endpoint;
	/// Constructor allocates soap engine context, sets default endpoint URL, and sets namespace mapping table
	MemberServiceSoap() { soap = soap_new(); if (soap) soap->namespaces = WS_MemberService_v3_namespaces; endpoint = "http://next2friends.com:90/MemberService.asmx"; };
	/// Destructor frees deserialized data and soap engine context
	virtual ~MemberServiceSoap() { if (soap) { soap_destroy(soap); soap_end(soap); soap_free(soap); } };
	/// Invoke 'CheckUserExists' of service 'MemberServiceSoap' and return error code (or SOAP_OK)
	virtual int __MemberServiceV32__CheckUserExists(_MemberServiceV3__CheckUserExists *MemberServiceV3__CheckUserExists, _MemberServiceV3__CheckUserExistsResponse *MemberServiceV3__CheckUserExistsResponse) { return soap ? soap_call___MemberServiceV32__CheckUserExists(soap, endpoint, NULL, MemberServiceV3__CheckUserExists, MemberServiceV3__CheckUserExistsResponse) : SOAP_EOM; };
	/// Invoke 'GetEncryptionKey' of service 'MemberServiceSoap' and return error code (or SOAP_OK)
	virtual int __MemberServiceV32__GetEncryptionKey(_MemberServiceV3__GetEncryptionKey *MemberServiceV3__GetEncryptionKey, _MemberServiceV3__GetEncryptionKeyResponse *MemberServiceV3__GetEncryptionKeyResponse) { return soap ? soap_call___MemberServiceV32__GetEncryptionKey(soap, endpoint, NULL, MemberServiceV3__GetEncryptionKey, MemberServiceV3__GetEncryptionKeyResponse) : SOAP_EOM; };
	/// Invoke 'GetMemberID' of service 'MemberServiceSoap' and return error code (or SOAP_OK)
	virtual int __MemberServiceV32__GetMemberID(_MemberServiceV3__GetMemberID *MemberServiceV3__GetMemberID, _MemberServiceV3__GetMemberIDResponse *MemberServiceV3__GetMemberIDResponse) { return soap ? soap_call___MemberServiceV32__GetMemberID(soap, endpoint, NULL, MemberServiceV3__GetMemberID, MemberServiceV3__GetMemberIDResponse) : SOAP_EOM; };
	/// Invoke 'GetTagID' of service 'MemberServiceSoap' and return error code (or SOAP_OK)
	virtual int __MemberServiceV32__GetTagID(_MemberServiceV3__GetTagID *MemberServiceV3__GetTagID, _MemberServiceV3__GetTagIDResponse *MemberServiceV3__GetTagIDResponse) { return soap ? soap_call___MemberServiceV32__GetTagID(soap, endpoint, NULL, MemberServiceV3__GetTagID, MemberServiceV3__GetTagIDResponse) : SOAP_EOM; };
	/// Invoke 'RemindPassword' of service 'MemberServiceSoap' and return error code (or SOAP_OK)
	virtual int __MemberServiceV32__RemindPassword(_MemberServiceV3__RemindPassword *MemberServiceV3__RemindPassword, _MemberServiceV3__RemindPasswordResponse *MemberServiceV3__RemindPasswordResponse) { return soap ? soap_call___MemberServiceV32__RemindPassword(soap, endpoint, NULL, MemberServiceV3__RemindPassword, MemberServiceV3__RemindPasswordResponse) : SOAP_EOM; };
};

} // namespace WS_MemberService_v3

#endif
