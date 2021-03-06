// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The AS2 agreement validation settings.
    /// </summary>
    public partial class AS2ValidationSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2ValidationSettings class.
        /// </summary>
        public AS2ValidationSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AS2ValidationSettings class.
        /// </summary>
        /// <param name="overrideMessageProperties">The value indicating
        /// whether to override incoming message properties with those in
        /// agreement.</param>
        /// <param name="encryptMessage">The value indicating whether the
        /// message has to be encrypted.</param>
        /// <param name="signMessage">The value indicating whether the message
        /// has to be signed.</param>
        /// <param name="compressMessage">The value indicating whether the
        /// message has to be compressed.</param>
        /// <param name="checkDuplicateMessage">The value indicating whether to
        /// check for duplicate message.</param>
        /// <param name="interchangeDuplicatesValidityDays">The number of days
        /// to look back for duplicate interchange.</param>
        /// <param name="checkCertificateRevocationListOnSend">The value
        /// indicating whether to check for certificate revocation list on
        /// send.</param>
        /// <param name="checkCertificateRevocationListOnReceive">The value
        /// indicating whether to check for certificate revocation list on
        /// receive.</param>
        /// <param name="encryptionAlgorithm">The encryption algorithm.
        /// Possible values include: 'NotSpecified', 'None', 'DES3', 'RC2',
        /// 'AES128', 'AES192', 'AES256'</param>
        /// <param name="signingAlgorithm">The signing algorithm. Possible
        /// values include: 'NotSpecified', 'Default', 'SHA1', 'SHA2256',
        /// 'SHA2384', 'SHA2512'</param>
        public AS2ValidationSettings(bool overrideMessageProperties, bool encryptMessage, bool signMessage, bool compressMessage, bool checkDuplicateMessage, int interchangeDuplicatesValidityDays, bool checkCertificateRevocationListOnSend, bool checkCertificateRevocationListOnReceive, EncryptionAlgorithm encryptionAlgorithm, string signingAlgorithm = default(string))
        {
            OverrideMessageProperties = overrideMessageProperties;
            EncryptMessage = encryptMessage;
            SignMessage = signMessage;
            CompressMessage = compressMessage;
            CheckDuplicateMessage = checkDuplicateMessage;
            InterchangeDuplicatesValidityDays = interchangeDuplicatesValidityDays;
            CheckCertificateRevocationListOnSend = checkCertificateRevocationListOnSend;
            CheckCertificateRevocationListOnReceive = checkCertificateRevocationListOnReceive;
            EncryptionAlgorithm = encryptionAlgorithm;
            SigningAlgorithm = signingAlgorithm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value indicating whether to override incoming
        /// message properties with those in agreement.
        /// </summary>
        [JsonProperty(PropertyName = "overrideMessageProperties")]
        public bool OverrideMessageProperties { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the message has to be
        /// encrypted.
        /// </summary>
        [JsonProperty(PropertyName = "encryptMessage")]
        public bool EncryptMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the message has to be
        /// signed.
        /// </summary>
        [JsonProperty(PropertyName = "signMessage")]
        public bool SignMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the message has to be
        /// compressed.
        /// </summary>
        [JsonProperty(PropertyName = "compressMessage")]
        public bool CompressMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for duplicate
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "checkDuplicateMessage")]
        public bool CheckDuplicateMessage { get; set; }

        /// <summary>
        /// Gets or sets the number of days to look back for duplicate
        /// interchange.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeDuplicatesValidityDays")]
        public int InterchangeDuplicatesValidityDays { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for certificate
        /// revocation list on send.
        /// </summary>
        [JsonProperty(PropertyName = "checkCertificateRevocationListOnSend")]
        public bool CheckCertificateRevocationListOnSend { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to check for certificate
        /// revocation list on receive.
        /// </summary>
        [JsonProperty(PropertyName = "checkCertificateRevocationListOnReceive")]
        public bool CheckCertificateRevocationListOnReceive { get; set; }

        /// <summary>
        /// Gets or sets the encryption algorithm. Possible values include:
        /// 'NotSpecified', 'None', 'DES3', 'RC2', 'AES128', 'AES192', 'AES256'
        /// </summary>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the signing algorithm. Possible values include:
        /// 'NotSpecified', 'Default', 'SHA1', 'SHA2256', 'SHA2384', 'SHA2512'
        /// </summary>
        [JsonProperty(PropertyName = "signingAlgorithm")]
        public string SigningAlgorithm { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
