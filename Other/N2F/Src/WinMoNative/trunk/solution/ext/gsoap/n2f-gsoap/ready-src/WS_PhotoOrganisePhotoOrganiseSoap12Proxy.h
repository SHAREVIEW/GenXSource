/* WS_PhotoOrganisePhotoOrganiseSoap12Proxy.h
   Generated by gSOAP 2.7.10 from .\wsdl-h\PhotoOrganise.h
   Copyright(C) 2000-2008, Robert van Engelen, Genivia Inc. All Rights Reserved.
   This part of the software is released under one of the following licenses:
   GPL, the gSOAP public license, or Genivia's license for commercial use.
*/

#ifndef WS_PhotoOrganisePhotoOrganiseSoap12Proxy_H
#define WS_PhotoOrganisePhotoOrganiseSoap12Proxy_H
#include "WS_PhotoOrganiseH.h"
extern SOAP_NMAC struct Namespace WS_PhotoOrganise_namespaces[];

namespace WS_PhotoOrganise {
class PhotoOrganiseSoap12
{   public:
	/// Runtime engine context allocated in constructor
	struct soap *soap;
	/// Endpoint URL of service 'PhotoOrganiseSoap12' (change as needed)
	const char *endpoint;
	/// Constructor allocates soap engine context, sets default endpoint URL, and sets namespace mapping table
	PhotoOrganiseSoap12() { soap = soap_new(); if (soap) soap->namespaces = WS_PhotoOrganise_namespaces; endpoint = "http://next2friends.com:90/PhotoOrganise.asmx"; };
	/// Destructor frees deserialized data and soap engine context
	virtual ~PhotoOrganiseSoap12() { if (soap) { soap_destroy(soap); soap_end(soap); soap_free(soap); } };
	/// Invoke 'Login' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__Login(_PhotoOrganise__Login *PhotoOrganise__Login, _PhotoOrganise__LoginResponse *PhotoOrganise__LoginResponse) { return soap ? soap_call___PhotoOrganise4__Login(soap, endpoint, NULL, PhotoOrganise__Login, PhotoOrganise__LoginResponse) : SOAP_EOM; };
	/// Invoke 'CreateNewCollection' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__CreateNewCollection(_PhotoOrganise__CreateNewCollection *PhotoOrganise__CreateNewCollection, _PhotoOrganise__CreateNewCollectionResponse *PhotoOrganise__CreateNewCollectionResponse) { return soap ? soap_call___PhotoOrganise4__CreateNewCollection(soap, endpoint, NULL, PhotoOrganise__CreateNewCollection, PhotoOrganise__CreateNewCollectionResponse) : SOAP_EOM; };
	/// Invoke 'GetCollections' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__GetCollections(_PhotoOrganise__GetCollections *PhotoOrganise__GetCollections, _PhotoOrganise__GetCollectionsResponse *PhotoOrganise__GetCollectionsResponse) { return soap ? soap_call___PhotoOrganise4__GetCollections(soap, endpoint, NULL, PhotoOrganise__GetCollections, PhotoOrganise__GetCollectionsResponse) : SOAP_EOM; };
	/// Invoke 'GetPhotosByCollection' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__GetPhotosByCollection(_PhotoOrganise__GetPhotosByCollection *PhotoOrganise__GetPhotosByCollection, _PhotoOrganise__GetPhotosByCollectionResponse *PhotoOrganise__GetPhotosByCollectionResponse) { return soap ? soap_call___PhotoOrganise4__GetPhotosByCollection(soap, endpoint, NULL, PhotoOrganise__GetPhotosByCollection, PhotoOrganise__GetPhotosByCollectionResponse) : SOAP_EOM; };
	/// Invoke 'UploadPhoto' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__UploadPhoto(_PhotoOrganise__UploadPhoto *PhotoOrganise__UploadPhoto, _PhotoOrganise__UploadPhotoResponse *PhotoOrganise__UploadPhotoResponse) { return soap ? soap_call___PhotoOrganise4__UploadPhoto(soap, endpoint, NULL, PhotoOrganise__UploadPhoto, PhotoOrganise__UploadPhotoResponse) : SOAP_EOM; };
	/// Invoke 'DeviceUploadPhoto' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__DeviceUploadPhoto(_PhotoOrganise__DeviceUploadPhoto *PhotoOrganise__DeviceUploadPhoto, _PhotoOrganise__DeviceUploadPhotoResponse *PhotoOrganise__DeviceUploadPhotoResponse) { return soap ? soap_call___PhotoOrganise4__DeviceUploadPhoto(soap, endpoint, NULL, PhotoOrganise__DeviceUploadPhoto, PhotoOrganise__DeviceUploadPhotoResponse) : SOAP_EOM; };
	/// Invoke 'JavaUploadPhoto' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__JavaUploadPhoto(_PhotoOrganise__JavaUploadPhoto *PhotoOrganise__JavaUploadPhoto, _PhotoOrganise__JavaUploadPhotoResponse *PhotoOrganise__JavaUploadPhotoResponse) { return soap ? soap_call___PhotoOrganise4__JavaUploadPhoto(soap, endpoint, NULL, PhotoOrganise__JavaUploadPhoto, PhotoOrganise__JavaUploadPhotoResponse) : SOAP_EOM; };
	/// Invoke 'RenameCollection' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__RenameCollection(_PhotoOrganise__RenameCollection *PhotoOrganise__RenameCollection, _PhotoOrganise__RenameCollectionResponse *PhotoOrganise__RenameCollectionResponse) { return soap ? soap_call___PhotoOrganise4__RenameCollection(soap, endpoint, NULL, PhotoOrganise__RenameCollection, PhotoOrganise__RenameCollectionResponse) : SOAP_EOM; };
	/// Invoke 'DeletePhoto' of service 'PhotoOrganiseSoap12' and return error code (or SOAP_OK)
	virtual int __PhotoOrganise4__DeletePhoto(_PhotoOrganise__DeletePhoto *PhotoOrganise__DeletePhoto, _PhotoOrganise__DeletePhotoResponse *PhotoOrganise__DeletePhotoResponse) { return soap ? soap_call___PhotoOrganise4__DeletePhoto(soap, endpoint, NULL, PhotoOrganise__DeletePhoto, PhotoOrganise__DeletePhotoResponse) : SOAP_EOM; };
};

} // namespace WS_PhotoOrganise

#endif
