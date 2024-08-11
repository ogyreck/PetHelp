using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHelp.Domain.Models
{
	public class Pet
	{

		private readonly List<Requisites> _requisitesForHelp = [];

		public Guid Id { get; set; }
		public string Name { get; set; } = default!;

		public Species? Species { get; set; }

		public string Description { get; set; } = default!;

		public Breed? Breed { get; set; }

		public string Color { get; set; } = default!;

		public string HealthInfo { get; set; } = default!;

		public string Adress { get; set; } = default!;

		public double Weight { get; set; }

		public double Height { get; set; }

		public string OwnerPhone { get; set; } = default!;

		public bool IsCostrated { get; set; }

		public DateOnly DateOfBirth { get; set; }

		public bool IsVaccinated { get; set; }

		public HelpStatus HelpStatus { get; set; }

		public IReadOnlyList<Requisites> RequisitesForHelp => _requisitesForHelp;

		public DateTime DateOfCreate { get; set; }

	}
}
