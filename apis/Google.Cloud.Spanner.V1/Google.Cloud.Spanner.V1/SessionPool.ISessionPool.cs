﻿// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using Google.Api.Gax;
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.V1
{
    public partial class SessionPool
    {
        /// <summary>
        /// Interface for communication between PooledSession and TargetedSessionPool/DetachedSessionPool.
        /// </summary>
        internal interface ISessionPool
        {
            Logger Logger { get; }
            SpannerClient Client { get; }
            IClock Clock { get; }
            void Release(PooledSession session, bool deleteSession);
            SessionPoolOptions Options { get; }
        }
    }
}
