using tutorialAPI.tutorialAPI.domain.model.aggregates;

namespace tutorialAPI.tutorialAPI.domain.repositories;

public interface IMedicationRepository
{
    Task<IEnumerable<Medication>> GetAllMedications();
    Task<Medication> GetDetails(int id);
    Task<bool> InsertMedication(Medication medication);
    Task<bool> UpdateMedication(Medication medication);
    Task<bool> DeleteMedication(Medication medication);
}