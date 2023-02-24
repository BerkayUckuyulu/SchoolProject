using System;
using Entities.Base;

namespace Entities
{
	public class Action:BaseClass
	{
		public bool IsActive { get; set; }
		public bool IsPublished { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public ICollection<Outline> Outlines { get; set; }
		public Course Course { get; set; }
		public ICollection<Document> Documents { get; set; }
		public short ActionType { get; set; }
		public bool IsTest { get; set; }
	}
}

