using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using OneFitnessVue.Data.EFContext;
using OneFitnessVue.Model.TaxMaster;

namespace OneFitnessVue.Data.TaxMaster.Queries
{
    public class TaxMasterQueries : ITaxMasterQueries
    {
        private readonly OneFitnessVueContext _oneFitnessVueContext;
        public TaxMasterQueries(OneFitnessVueContext oneFitnessVueContext)
        {
            _oneFitnessVueContext = oneFitnessVueContext;
        }


        public List<SelectListItem> GetTaxList()
        {
            try
            {
                var workoutslist = new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Text = "SGST",
                        Value = "1"
                    },
                    new SelectListItem()
                    {
                        Text = "CGST",
                        Value = "2"
                    }
                };

                workoutslist.Insert(0, new SelectListItem()
                {
                    Value = "",
                    Text = "---Select---"
                });

                return workoutslist;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public TaxMasterModel GetTaxDetailsbyTaxId(int taxId)
        {
            TaxMasterModel taxdetails;
            switch (taxId)
            {
                case 1:
                    taxdetails = new TaxMasterModel()
                    {
                        TaxId = 1,
                        Status = true,
                        TaxRate = 5,
                        TaxType = "SGST",
                        IdentificationNo = "155555555555"
                    };
                    return taxdetails;

                case 2:
                    taxdetails = new TaxMasterModel()
                    {
                        TaxId = 2,
                        Status = true,
                        TaxRate = 5,
                        TaxType = "CGST",
                        IdentificationNo = "155555555555"
                    };
                    return taxdetails;
                default:
                    taxdetails = new TaxMasterModel();
                    return taxdetails;

            }

        }
    }
}