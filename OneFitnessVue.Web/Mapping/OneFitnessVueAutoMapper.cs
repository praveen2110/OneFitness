using AutoMapper;
using OneFitnessVue.Model.MemberRegistration;
using OneFitnessVue.ViewModel.MemberRegistration;

namespace OneFitnessVue.Web.Mapping
{
    public class OneFitnessVueAutoMapper : Profile
    {
        public OneFitnessVueAutoMapper()
        {
            CreateMap<MemberRegistrationViewModel, MemberRegistrationModel>();
            CreateMap<EditMemberRegistrationViewModel, MemberRegistrationModel>();            
        }
    }
}