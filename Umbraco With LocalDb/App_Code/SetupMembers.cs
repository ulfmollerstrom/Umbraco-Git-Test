using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace Umbraco_With_LocalDb.App_Code
{
    public class SetupMembers
    {
        private readonly IMemberService memberService = ApplicationContext.Current.Services.MemberService;

        public void DeleteMembers()
        {

        }

        public void CreateNisseHult()
        {
            memberService.Save(
                memberService.CreateMemberWithIdentity("Nisse Hult", "nisse@hult.nu", "Nisse Hult", "Demo"));
        }

        public void CreateMembers()
        {
            try
            {
                foreach (var member in MembersToAdd())
                {
                    memberService.Save(member);
                    memberService.SavePassword(member, "P@$$w0rd");
                }
            }
            catch (Exception exception)
            {
                var tmp = exception;
            }
        }

        private IEnumerable<IMember> MembersToAdd()
        {
            var members = new List<IMember>
            {
                memberService.CreateMemberWithIdentity("Luke Skywalker", "mark.hamill@sci-fi.space", "Mark Hamill", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Han Solo", "harrison.ford@sci-fi.space", "Harrison Ford", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Princess Leia Organa", "carrie.fisher@sci-fi.space", "Carrie Fisher", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Ben Obi-Wan Kenobi", "alec.guinness@sci-fi.space", "Alec Guinness", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("C-3PO", "anthony.daniels@sci-fi.space", "Anthony Daniels", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("R2-D2", "kenny.baker@sci-fi.space", "Kenny Baker", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Chewbacca", "peter.mayhew@sci-fi.space", "Peter Mayhew", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Darth Vader", "david.prowse@sci-fi.space", "David Prowse", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Dallas", "tom.skerritt@sci-fi.space", "Tom Skerritt", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Ripley", "sigourney.weaver@sci-fi.space", "Sigourney Weaver", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Lambert", "veronica.cartwright@sci-fi.space", "Veronica Cartwright", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Brett", "harry.dean.stanton@sci-fi.space", "Harry Dean Stanton", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Kane", "john.hurt@sci-fi.space", "John Hurt", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Ash", "ian.holm@sci-fi.space", "Ian Holm", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Parker", "yaphet.kotto@sci-fi.space", "Yaphet Kotto", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Newt", "carrie.henn@sci-fi.space", "Carrie Henn", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Corporal Hicks", "michael.biehn@sci-fi.space", "Michael Biehn", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Burke", "paul.reiser@sci-fi.space", "Paul Reiser", "SciFiCaracters"),
                memberService.CreateMemberWithIdentity("Bishop", "lance.henriksen@sci-fi.space", "Lance Henriksen", "SciFiCaracters")
            };

            foreach (var member in members)
            {
                yield return member;
            }
        }
    }
}