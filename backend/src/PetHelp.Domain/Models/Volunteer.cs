using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHelp.Domain.Models
{
	public class Volunteer
	{

		public readonly List<SocialNetwork> _socialNetworks = [];

		private readonly List<Requisites> _requisitesForHelp = [];

		private readonly List<Pet> _petsOwnedVolunteer = [];

		public Guid Id { get; set; }

		public string FullName { get; set; } = default!;

		public string Description { get; set; } = default!;


		public int YearsOfExperience { get; set; }

		public int CountPetGetHome { get; set; }

		public int CountPetSearchHome {  get; set; }

		public int CountPetNeedHelp { get; set; }

		public string PhoneNumber { get; set; } = default!;

		public IReadOnlyList<SocialNetwork> SocialNetworks => _socialNetworks;

		public IReadOnlyList<Requisites> RequisitesForHelp => _requisitesForHelp;

		public IReadOnlyList<Pet> PetsOwnedVolunteer => _petsOwnedVolunteer;






	}
}
