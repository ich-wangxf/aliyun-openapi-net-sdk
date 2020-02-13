/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;

namespace Aliyun.Acs.pvtz
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "cn-shenzhen", "pvtz.cn-shenzhen.aliyuncs.com" },
            { "cn-beijing", "pvtz.cn-beijing.aliyuncs.com" },
            { "cn-shanghai", "pvtz.cn-shanghai.aliyuncs.com" },
            { "cn-hongkong", "pvtz.cn-hongkong.aliyuncs.com" },
            { "ap-southeast-1", "pvtz.ap-southeast-1.aliyuncs.com" },
            { "ap-southeast-3", "pvtz.ap-southeast-3.aliyuncs.com" },
            { "eu-central-1", "pvtz.eu-central-1.aliyuncs.com" },
            { "cn-huhehaote", "pvtz.cn-huhehaote.aliyuncs.com" },
            { "ap-southeast-5", "pvtz.ap-southeast-5.aliyuncs.com" },
            { "cn-zhangjiakou", "pvtz.cn-zhangjiakou.aliyuncs.com" },
            { "cn-chengdu", "pvtz.cn-chengdu.aliyuncs.com" },
        };

        public static string endpointRegionalType = "central";
    }
}