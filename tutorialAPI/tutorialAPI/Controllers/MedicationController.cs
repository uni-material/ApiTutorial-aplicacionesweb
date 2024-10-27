using Microsoft.AspNetCore.Mvc;
using tutorialAPI.tutorialAPI.domain.repositories;

namespace tutorialAPI.tutorialAPI.Controllers;

[ApiController]
[Route("api/v1/[controller]")]

public class MedicationController : ControllerBase
{

    private readonly IMedicationRepository _medicationRepository;

    public MedicationController(IMedicationRepository medicationRepository)
    {
        _medicationRepository = medicationRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllMedications()
    {
        return Ok(await _medicationRepository.GetAllMedications());
    }
    
    
    
    //[HttpPost]
    //[Route("save")]
    //public dynamic saceMedication()
    //{
    //    
    //}



}