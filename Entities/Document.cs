using System;
using Entities.Base;

namespace Entities
{
	public class Document:BaseClass
	{
		public string? DocumentPath { get; set; }
		public string MimeType { get; set; }
		public string? DocumentName { get; set; }
		public int Size { get; set; }
		public AppUser AppUser { get; set; }
		public Action? Action { get; set; }

	}
}

