using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tpmodul10_103022300015;

namespace tpmodul10_NIM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Gamaliel Pradana P", Nim = "103022300015" },
            new Mahasiswa { Nama = "James Bond", Nim = "103022300016" },
            new Mahasiswa { Nama = "John Wick", Nim = "103022300017" }
        };

       
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return daftarMahasiswa;
        }

        
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            return daftarMahasiswa[index];
        }

        
        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswaBaru)
        {
            daftarMahasiswa.Add(mahasiswaBaru);
        }

        
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            if (index >= 0 && index < daftarMahasiswa.Count)
            {
                daftarMahasiswa.RemoveAt(index);
            }
        }
    }
}
