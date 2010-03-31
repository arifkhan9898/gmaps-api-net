﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Google.Api.Maps.Service.Geocoding;

namespace Google.Api.Maps
{
	public class Address : AddressBase
	{
		[AddressComponent(AddressType.Route)]
		public string Street { get; set; }

		[AddressComponent(AddressType.StreetNumber)]
		public int Number { get; set; }

		[AddressComponent(AddressType.PostalCode)]
		public string PostalCode { get; set; }

		[AddressComponent(AddressType.Neighborhood, AddressType.Locality, AddressType.AdministrativeAreaLevel3)]
		public Location City { get; set; }

		[AddressComponent(AddressType.AdministrativeAreaLevel2)]
		public Location County { get; set; }

		[AddressComponent(AddressType.AdministrativeAreaLevel1)]
		public Location State { get; set; }

		[AddressComponent(AddressType.Country)]
		public Location Country { get; set; }
	}
}
