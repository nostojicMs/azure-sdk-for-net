﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Identity
{
    /// <summary>
    /// Options to configure requests made to the OAUTH identity service.
    /// </summary>
    public class TokenCredentialOptions : ClientOptions
    {
        private Uri _authorityHost;

        /// <summary>
        /// Constructs a new <see cref="TokenCredentialOptions"/> instance.
        /// </summary>
        public TokenCredentialOptions()
            : base(diagnostics: new TokenCredentialDiagnosticsOptions())
        {
        }

        /// <summary>
        /// The host of the Azure Active Directory authority. The default is https://login.microsoftonline.com/. For well known authority hosts for Azure cloud instances see <see cref="AzureAuthorityHosts"/>.
        /// </summary>
        public Uri AuthorityHost
        {
            get { return _authorityHost ?? AzureAuthorityHosts.GetDefault(); }
            set { _authorityHost = Validations.ValidateAuthorityHost(value); }
        }

        /// <summary>
        /// Gets or sets value indicating if ETW logging that contains PII content should be logged.
        /// Setting this property will not disable redaction of <see cref="Request"/> Content. To enable logging of sensitive <see cref="Request.Content"/>
        /// the <see cref="DiagnosticsOptions.IsLoggingContentEnabled"/> property must be set to <c>true</c>.
        /// </summary>
        internal bool IsLoggingPIIEnabled { get; set; }

        /// <summary>
        /// Gets the credential diagnostic options.
        /// </summary>
        public new TokenCredentialDiagnosticsOptions Diagnostics => base.Diagnostics as TokenCredentialDiagnosticsOptions;
    }
}
