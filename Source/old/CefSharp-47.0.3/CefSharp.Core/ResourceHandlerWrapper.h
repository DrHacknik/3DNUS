﻿// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

#pragma once

#include "Stdafx.h"
#include "include/cef_scheme.h"

using namespace System::IO;
using namespace System::Collections::Specialized;

namespace CefSharp
{
    public class ResourceHandlerWrapper : public CefResourceHandler
    {
    private:
        gcroot<IRequest^> _request;
        gcroot<IResourceHandler^> _handler;
        gcroot<Stream^> _stream;
        gcroot<IBrowser^> _browser;
        gcroot<IFrame^> _frame;

        int64 SizeFromStream();

    public:

        /// <summary>
        /// Constructor that accepts IBrowser, IFrame, IRequest in order to be the CefSharp
        /// lifetime management container  (i.e. calling .Dispose at the correct time) on 
        /// managed objects that contain MCefRefPtrs.
        /// </summary>
        ResourceHandlerWrapper(IResourceHandler^ handler, IBrowser ^browser, IFrame^ frame, IRequest^ request)
            : _handler(handler), _browser(browser), _frame(frame), _request(request)
        {
        }

        ~ResourceHandlerWrapper()
        {
            _handler = nullptr;
            _stream = nullptr;
            delete _request;
            delete _browser;
            delete _frame;
        }

        virtual bool ProcessRequest(CefRefPtr<CefRequest> request, CefRefPtr<CefCallback> callback) OVERRIDE;
        virtual void GetResponseHeaders(CefRefPtr<CefResponse> response, int64& response_length, CefString& redirectUrl) OVERRIDE;
        virtual bool ReadResponse(void* data_out, int bytes_to_read, int& bytes_read, CefRefPtr<CefCallback> callback) OVERRIDE;
        virtual bool CanGetCookie(const CefCookie& cookie) OVERRIDE;
        virtual bool CanSetCookie(const CefCookie& cookie) OVERRIDE;
        virtual void Cancel() OVERRIDE;

        IMPLEMENT_REFCOUNTING(ResourceHandlerWrapper);
    };
}