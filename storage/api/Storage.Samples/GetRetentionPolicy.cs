// Copyright 2020 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// [START storage_get_retention_policy]

using Google.Cloud.Storage.V1;
using System;
using static Google.Apis.Storage.v1.Data.Bucket;

public class GetRetentionPolicySample
{
    public RetentionPolicyData GetRetentionPolicy(string bucketName = "your-unique-bucket-name")
    {
        var storage = StorageClient.Create();
        var bucket = storage.GetBucket(bucketName);

        if (bucket.RetentionPolicy != null)
        {
            Console.WriteLine("Retention policy:");
            Console.WriteLine($"Period: {bucket.RetentionPolicy.RetentionPeriod}");
            Console.WriteLine($"Effective time: {bucket.RetentionPolicy.EffectiveTime}");
            bool isLocked = bucket.RetentionPolicy.IsLocked ?? false;
            Console.WriteLine($"Policy locked: {isLocked}");
        }
        return bucket.RetentionPolicy;
    }
}
// [END storage_get_retention_policy]
