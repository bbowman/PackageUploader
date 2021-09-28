﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

namespace GameStoreBroker.ClientApi.Client.Ingestion.Models
{
    public sealed class GameSubmissionOptions
    {
        /// <summary>
        /// Scheduled release time (UTC). Default value is null, and submission will be published as soon as possible.
        /// </summary>
        public DateTime? ReleaseTimeInUtc { get; init; }

        /// <summary>
        /// Flag of if manual publish is enabled. Default value is false.
        /// </summary>
        public bool IsManualPublish { get; init; }

        /// <summary>
        /// Flag of if auto promotion is enabled. Default value is false.
        /// </summary>
        public bool IsAutoPromote { get; init; }

        /// <summary>
        /// Certification notes
        /// </summary>
        public string CertificationNotes { get; init; }
    }
}
