using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RunLib.model;
using RunLib.repository;

namespace RazorRun.Pages.Members
{
    public class IndexModel : PageModel

    {
        //Dependency injection
        //Instans
        private MemberRepository _repo;
        //Konstruktør
        public IndexModel(MemberRepository repo)
        {
            _repo = repo;
        }

        //Property til view
        public List<Member> Members { get; set; }

        public void OnGet()
        {
            Members = _repo.GetAll();
        }
    }
}
