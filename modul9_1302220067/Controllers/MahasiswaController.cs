using Microsoft.AspNetCore.Mvc;
using modul9_1302220067;

namespace modul9_1302220067.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public List<Mahasiswa> mahasiswaList = [
            new Mahasiswa("Febry Twenido", "130222000", ["KPL"], 20),
            new Mahasiswa("Fionadhilla", "130222000", ["PBO", "KPL"], 20),
            new Mahasiswa("Henri Silas", "130222000", ["PBO", "KPL"], 21)
        ];

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Show(int id)
        {
            try
            {
               return mahasiswaList[id];

            } catch(Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public Mahasiswa Store(Mahasiswa mahasiswa)
        {
            var mhs = new Mahasiswa(mahasiswa.Name, mahasiswa.Nim, mahasiswa.Course, mahasiswa.Year);
            mahasiswaList.Add(mhs);
            return mhs;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var mahasiswa = mahasiswaList[id];
                mahasiswaList.RemoveAt(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
