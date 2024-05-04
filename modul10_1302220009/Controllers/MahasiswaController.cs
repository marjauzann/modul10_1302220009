using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220009.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<string> Course1 = new List<string> { "KPL", "BD", "PBO" };
        private static List<string> Course2 = new List<string> { "KPL", "BD", "PBO" };
        private static List<string> Course3 = new List<string> { "KPL", "BD", "PBO" };
        private static List<string> Course4 = new List<string> { "KPL", "BD", "PBO" };
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Marjauza Naswansyah", "1302220009", Course1, 2019),
        new Mahasiswa(" Nizar Rasyiid", "1302220037", Course2, 2019),
        new Mahasiswa(" Hasan Nurrahman Pane", "1302220031", Course3, 2019),
        new Mahasiswa(" Matthew Theodore Lempas" , "1302223116", Course4, 2019),
    };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}