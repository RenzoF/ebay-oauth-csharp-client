﻿/*
 * *
 *  * Copyright 2019 eBay Inc.
 *  *
 *  * Licensed under the Apache License, Version 2.0 (the "License");
 *  * you may not use this file except in compliance with the License.
 *  * You may obtain a copy of the License at
 *  *
 *  *  http://www.apache.org/licenses/LICENSE-2.0
 *  *
 *  * Unless required by applicable law or agreed to in writing, software
 *  * distributed under the License is distributed on an "AS IS" BASIS,
 *  * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  * See the License for the specific language governing permissions and
 *  * limitations under the License.
 *  *
 */

using System;
using Xunit;
using eBay.ApiClient.Auth.OAuth2.Model;

namespace eBay.ApiClient.Auth.OAuth2
{
    public class CredentialUtilTest
    {

        [Fact]
        public void GetCredentials_Success()
        {
            String path = @"../../../ebay-config-sample.yaml";
            CredentialUtil.Load(path);
            CredentialUtil.Credentials credentials = CredentialUtil.GetCredentials(OAuthEnvironment.PRODUCTION);
            Assert.NotNull(credentials);
            Assert.NotNull(credentials.Get(CredentialType.APP_ID));
            Assert.NotNull(credentials.Get(CredentialType.DEV_ID));
            Assert.NotNull(credentials.Get(CredentialType.CERT_ID));
            Assert.NotNull(credentials.Get(CredentialType.REDIRECT_URI));
        }
        public void LoadCredentialsCustom_Success()
        {
            String path = @"../../../ebay-config-sample.yaml";



            CredentialUtil.Load(path);
            CredentialUtil.Credentials credentials = CredentialUtil.GetCredentials(OAuthEnvironment.PRODUCTION);
            Assert.NotNull(credentials);
            Assert.NotNull(credentials.Get(CredentialType.APP_ID));
            Assert.NotNull(credentials.Get(CredentialType.DEV_ID));
            Assert.NotNull(credentials.Get(CredentialType.CERT_ID));
            Assert.NotNull(credentials.Get(CredentialType.REDIRECT_URI));
        }

    }
}