using Winform.Model;
using Winform.Repository;
using Winform.View.Member;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MemberRepository memberRepository = new MemberRepository(); 
            Member member = memberRepository.ListAll().First();

            Application.Run(new FormMemberMain(member));
        }
    }
}