namespace PetHelp.Domain.Models
{
	public class Species
	{
		private readonly List<Breed> _breeds = [];

		public Guid Id { get; private set; }

		public string Name { get; private set; } = default!;

		public IReadOnlyList<Breed> Breeds => _breeds;

	}
}
