/* WS_MemberServices_v2Client.cpp
   Generated by gSOAP 2.7.10 from .\wsdl-h\MemberServices.v2.h
   Copyright(C) 2000-2008, Robert van Engelen, Genivia Inc. All Rights Reserved.
   This part of the software is released under one of the following licenses:
   GPL, the gSOAP public license, or Genivia's license for commercial use.
*/
#include "WS_MemberServices_v2H.h"

namespace WS_MemberServices_v2 {

SOAP_SOURCE_STAMP("@(#) WS_MemberServices_v2Client.cpp ver 2.7.10 2008-04-15 20:09:21 GMT")


SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServicesV22__GetEncryptionKey(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServicesV2__GetEncryptionKey *MemberServicesV2__GetEncryptionKey, _MemberServicesV2__GetEncryptionKeyResponse *MemberServicesV2__GetEncryptionKeyResponse)
{	struct __MemberServicesV22__GetEncryptionKey soap_tmp___MemberServicesV22__GetEncryptionKey;
	if (!soap_endpoint)
		soap_endpoint = "http://services.next2friends.com/n2fwebservices/memberservices.asmx";
	if (!soap_action)
		soap_action = "http://tempuri.org/GetEncryptionKey";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServicesV22__GetEncryptionKey.MemberServicesV2__GetEncryptionKey = MemberServicesV2__GetEncryptionKey;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServicesV22__GetEncryptionKey(soap, &soap_tmp___MemberServicesV22__GetEncryptionKey);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServicesV22__GetEncryptionKey(soap, &soap_tmp___MemberServicesV22__GetEncryptionKey, "-MemberServicesV22:GetEncryptionKey", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServicesV22__GetEncryptionKey(soap, &soap_tmp___MemberServicesV22__GetEncryptionKey, "-MemberServicesV22:GetEncryptionKey", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServicesV2__GetEncryptionKeyResponse)
		return soap_closesock(soap);
	MemberServicesV2__GetEncryptionKeyResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServicesV2__GetEncryptionKeyResponse->soap_get(soap, "MemberServicesV2:GetEncryptionKeyResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServicesV22__GetMemberID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServicesV2__GetMemberID *MemberServicesV2__GetMemberID, _MemberServicesV2__GetMemberIDResponse *MemberServicesV2__GetMemberIDResponse)
{	struct __MemberServicesV22__GetMemberID soap_tmp___MemberServicesV22__GetMemberID;
	if (!soap_endpoint)
		soap_endpoint = "http://services.next2friends.com/n2fwebservices/memberservices.asmx";
	if (!soap_action)
		soap_action = "http://tempuri.org/GetMemberID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServicesV22__GetMemberID.MemberServicesV2__GetMemberID = MemberServicesV2__GetMemberID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServicesV22__GetMemberID(soap, &soap_tmp___MemberServicesV22__GetMemberID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServicesV22__GetMemberID(soap, &soap_tmp___MemberServicesV22__GetMemberID, "-MemberServicesV22:GetMemberID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServicesV22__GetMemberID(soap, &soap_tmp___MemberServicesV22__GetMemberID, "-MemberServicesV22:GetMemberID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServicesV2__GetMemberIDResponse)
		return soap_closesock(soap);
	MemberServicesV2__GetMemberIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServicesV2__GetMemberIDResponse->soap_get(soap, "MemberServicesV2:GetMemberIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServicesV22__GetTagID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServicesV2__GetTagID *MemberServicesV2__GetTagID, _MemberServicesV2__GetTagIDResponse *MemberServicesV2__GetTagIDResponse)
{	struct __MemberServicesV22__GetTagID soap_tmp___MemberServicesV22__GetTagID;
	if (!soap_endpoint)
		soap_endpoint = "http://services.next2friends.com/n2fwebservices/memberservices.asmx";
	if (!soap_action)
		soap_action = "http://tempuri.org/GetTagID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServicesV22__GetTagID.MemberServicesV2__GetTagID = MemberServicesV2__GetTagID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServicesV22__GetTagID(soap, &soap_tmp___MemberServicesV22__GetTagID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServicesV22__GetTagID(soap, &soap_tmp___MemberServicesV22__GetTagID, "-MemberServicesV22:GetTagID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServicesV22__GetTagID(soap, &soap_tmp___MemberServicesV22__GetTagID, "-MemberServicesV22:GetTagID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServicesV2__GetTagIDResponse)
		return soap_closesock(soap);
	MemberServicesV2__GetTagIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServicesV2__GetTagIDResponse->soap_get(soap, "MemberServicesV2:GetTagIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServicesV23__GetEncryptionKey(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServicesV2__GetEncryptionKey *MemberServicesV2__GetEncryptionKey, _MemberServicesV2__GetEncryptionKeyResponse *MemberServicesV2__GetEncryptionKeyResponse)
{	struct __MemberServicesV23__GetEncryptionKey soap_tmp___MemberServicesV23__GetEncryptionKey;
	if (!soap_endpoint)
		soap_endpoint = "http://services.next2friends.com/n2fwebservices/memberservices.asmx";
	if (!soap_action)
		soap_action = "http://tempuri.org/GetEncryptionKey";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServicesV23__GetEncryptionKey.MemberServicesV2__GetEncryptionKey = MemberServicesV2__GetEncryptionKey;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServicesV23__GetEncryptionKey(soap, &soap_tmp___MemberServicesV23__GetEncryptionKey);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServicesV23__GetEncryptionKey(soap, &soap_tmp___MemberServicesV23__GetEncryptionKey, "-MemberServicesV23:GetEncryptionKey", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServicesV23__GetEncryptionKey(soap, &soap_tmp___MemberServicesV23__GetEncryptionKey, "-MemberServicesV23:GetEncryptionKey", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServicesV2__GetEncryptionKeyResponse)
		return soap_closesock(soap);
	MemberServicesV2__GetEncryptionKeyResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServicesV2__GetEncryptionKeyResponse->soap_get(soap, "MemberServicesV2:GetEncryptionKeyResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServicesV23__GetMemberID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServicesV2__GetMemberID *MemberServicesV2__GetMemberID, _MemberServicesV2__GetMemberIDResponse *MemberServicesV2__GetMemberIDResponse)
{	struct __MemberServicesV23__GetMemberID soap_tmp___MemberServicesV23__GetMemberID;
	if (!soap_endpoint)
		soap_endpoint = "http://services.next2friends.com/n2fwebservices/memberservices.asmx";
	if (!soap_action)
		soap_action = "http://tempuri.org/GetMemberID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServicesV23__GetMemberID.MemberServicesV2__GetMemberID = MemberServicesV2__GetMemberID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServicesV23__GetMemberID(soap, &soap_tmp___MemberServicesV23__GetMemberID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServicesV23__GetMemberID(soap, &soap_tmp___MemberServicesV23__GetMemberID, "-MemberServicesV23:GetMemberID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServicesV23__GetMemberID(soap, &soap_tmp___MemberServicesV23__GetMemberID, "-MemberServicesV23:GetMemberID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServicesV2__GetMemberIDResponse)
		return soap_closesock(soap);
	MemberServicesV2__GetMemberIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServicesV2__GetMemberIDResponse->soap_get(soap, "MemberServicesV2:GetMemberIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServicesV23__GetTagID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServicesV2__GetTagID *MemberServicesV2__GetTagID, _MemberServicesV2__GetTagIDResponse *MemberServicesV2__GetTagIDResponse)
{	struct __MemberServicesV23__GetTagID soap_tmp___MemberServicesV23__GetTagID;
	if (!soap_endpoint)
		soap_endpoint = "http://services.next2friends.com/n2fwebservices/memberservices.asmx";
	if (!soap_action)
		soap_action = "http://tempuri.org/GetTagID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServicesV23__GetTagID.MemberServicesV2__GetTagID = MemberServicesV2__GetTagID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServicesV23__GetTagID(soap, &soap_tmp___MemberServicesV23__GetTagID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServicesV23__GetTagID(soap, &soap_tmp___MemberServicesV23__GetTagID, "-MemberServicesV23:GetTagID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServicesV23__GetTagID(soap, &soap_tmp___MemberServicesV23__GetTagID, "-MemberServicesV23:GetTagID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServicesV2__GetTagIDResponse)
		return soap_closesock(soap);
	MemberServicesV2__GetTagIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServicesV2__GetTagIDResponse->soap_get(soap, "MemberServicesV2:GetTagIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

} // namespace WS_MemberServices_v2


/* End of WS_MemberServices_v2Client.cpp */
