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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class QueryMonitorKeywordsRequest : RpcAcsRequest<QueryMonitorKeywordsResponse>
    {
        public QueryMonitorKeywordsRequest()
            : base("Trademark", "2018-07-24", "QueryMonitorKeywords", "trademark", "openAPI")
        {
        }

		private List<string> keywordss;

		private int? ruleType;

		public List<string> Keywordss
		{
			get
			{
				return keywordss;
			}

			set
			{
				keywordss = value;
				for (int i = 0; i < keywordss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Keywords." + (i + 1) , keywordss[i]);
				}
			}
		}

		public int? RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(QueryParameters, "RuleType", value.ToString());
			}
		}

        public override QueryMonitorKeywordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryMonitorKeywordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
