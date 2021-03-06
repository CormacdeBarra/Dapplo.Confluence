﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2015-2016 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Confluence
// 
//  Dapplo.Confluence is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Confluence is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Confluence. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#region using

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Dapplo.Confluence.Entities
{
	/// <summary>
	///     Space information
	///     See: https://docs.atlassian.com/confluence/REST/latest
	///     Should be called with expand=icon,description.plain,homepage
	/// </summary>
	[DataContract]
	public class Space
	{
		/// <summary>
		/// The values that are expandable
		/// </summary>
		[DataMember(Name = "_expandable")]
		public IDictionary<string, string> Expandables { get; set; }

		/// <summary>
		/// Icon for the space
		/// </summary>
		[DataMember(Name = "icon")]
		public Picture Icon { get; set; }

		/// <summary>
		/// Id for the space
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }

		/// <summary>
		/// Test if this space is a personal space, this is true when the Key starts with a ~
		/// </summary>
		public bool IsPersonal => true == Key?.StartsWith("~");

		/// <summary>
		/// Key for the space
		/// </summary>
		[DataMember(Name = "key")]
		public string Key { get; set; }

		/// <summary>
		/// Different links for this entity, depending on the entry
		/// </summary>
		[DataMember(Name = "_links")]
		public Links Links { get; set; }

		/// <summary>
		/// The name of the space
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Type for the space, e.g. Team space or Knowledge Base space etc
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public Description Description { get; set; }
	}
}