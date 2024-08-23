using Microsoft.AspNetCore.Mvc;

public class ContactManagementController : BaseController
{
    private readonly ContactStorage contactStorage;

    // storage вызываем конструктор
    public ContactManagementController(ContactStorage contactStorage)
    {
        this.contactStorage = contactStorage;
    }

    [HttpPost("contacts")]
    public IActionResult CreateContact([FromBody] Contact contact)
    {
        bool result = contactStorage.AddContact(contact);
        if (result)
        {
            return Created();
        }
        return Conflict("контакт с указанным id уже существует");
    }

    [HttpGet("contacts")]
    public ActionResult<List<Contact>> GetContact()
    {
        return Ok(contactStorage.GetContacts());
    }

    // [HttpGet("contacts/{id}")]
    // public ActionResult<List<Contact>> GetContactById(int id)
    // {
    //     bool result = contactStorage.GetContactById(id);
    //     if (result)
    //     {
    //         return Ok(contactStorage.GetContactById(id));
    //     }
    //     return Conflict("контакт с указанным id не найден");
    // }

    [HttpDelete("contacts/{id}")]
    public IActionResult DeleteContact(int id)
    {
        bool result = contactStorage.DeleteContact(id);
        if (result)
        {
            return NoContent();
        }
        return BadRequest("Ошибка Id");
    }

    [HttpPut("contacts/{id}")]
    public IActionResult UpdateContact([FromBody] ContactDto contactDto, int id)
    {
        bool result = contactStorage.UpdateContact(contactDto, id);
        if (result) return Ok();
        return Conflict("контакт с указанным id не найден");
    }
}