using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace PmDash.Models
{
    public static  class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Investors.Any())
            {
                context.Investors.AddRange(
                    new Investor
                    {
                        Name = "Thapi Aqua-Kulture",
                        Lease = "No",
                        Asset = "building",
                        InvestmentValue = 50000000,
                        TeamMembers = "MandlaM",
                        Status = " Project Appoved",
                        Category = "Aquaculture Development Zone"
                    },
                    new Investor
                    {
                        Name = "Bay Agriculture",
                        Lease = "Mybe",
                        Asset = "Land",
                        InvestmentValue = 70000000,
                        TeamMembers = "Soamndla",
                        Status = " Project Appoved",
                        Category = "Aquaculture Development Zone"
                    },
                    new Investor
                    {
                        Name = "Desalination Plant",
                        Lease = "N/A",
                        Asset = "building",
                        InvestmentValue = 350000000,
                        TeamMembers = "MandlaM",
                        Status = " Project not sure",
                        Category = "Desalination"
                    },
                    new Investor
                    {
                        Name = "AAP Industries",
                        Lease = "No",
                        Asset = "building",
                        InvestmentValue = 380000000,
                        TeamMembers = "SimphiweS",
                        Status = " Project not sure",
                        Category = "Wild Coast Sez"
                    },
                    new Investor
                    {
                        Name = "Whey",
                        Lease = "No",
                        Asset = "Building",
                        InvestmentValue = 50000000,
                        TeamMembers = "JabuM",
                        Status = " Project Appoved By DG Board",
                        Category = "Other"
                    }
                    );
                if (!context.AquaDevelopments.Any())
                {
                    context.AquaDevelopments.AddRange(
                         new AquaDevelopment
                         {
                             Name = "Thapi Aqua-Kulture",
                             Lease = "No",
                             Asset = "building",
                             InvestmentValue = 50000000,
                             TeamMembers = "MandlaM",
                             Status = " Project Appoved"
                         },
                         new AquaDevelopment
                         {
                             Name = "Bay Agriculture",
                             Lease = "Mybe",
                             Asset = "Land",
                             InvestmentValue = 70000000,
                             TeamMembers = "Ubuntu",
                             Status = " Project Appoved"
                         }

                         );
                    if (!context.Desalinations.Any())
                    {
                        context.Desalinations.AddRange(
                            new Desalination
                            {
                                Name = "Desalination Plant",
                                Lease = "N/A",
                                Asset = "building",
                                InvestmentValue = 350000000,
                                TeamMembers = "Ubuntu",
                                Status = " Project not sure"
                            });

                    }
                    if (!context.Documents.Any())
                    {
                        context.Documents.AddRange(
                            new Document
                            {
                                Name = "Thapi Aqua-Kulture",
                                Pdd = "Yes",
                                BSA = "No",
                                Eq = "No",
                                FundingApproval = "No",
                                Investment = 0,
                                FeesAgreement = "No",
                                Prc = "No",
                                Rmc = "No",
                                Frc = "No",
                                Exma = "No",
                                Converted = "No"
                            },
                            new Document
                            {
                                Name = "Bay Aquaculture",
                                Pdd = "No",
                                BSA = "Yes",
                                Eq = "No",
                                FundingApproval = "No",
                                Investment = 0,
                                FeesAgreement = "No",
                                Prc = "No",
                                Rmc = "No",
                                Frc = "No",
                                Exma = "No",
                                Converted = "No"
                            },
                            new Document
                            {
                                Name = "AAP Industries",
                                Pdd = "No",
                                BSA = "Yes",
                                Eq = "Yes",
                                FundingApproval = "No",
                                Investment = 0,
                                FeesAgreement = "No",
                                Prc = "No",
                                Rmc = "No",
                                Frc = "No",
                                Exma = "No",
                                Converted = "No"
                            },
                            new Document
                            {
                                Name = "Whey",
                                Pdd = "Pdd-Yes",
                                BSA = "Yes",
                                Eq = "Yes",
                                FundingApproval = "Yes",
                                Investment = 125000000,
                                FeesAgreement = "Yes",
                                Prc = "Yes",
                                Rmc = "Yes",
                                Frc = "Yes",
                                Exma = "No",
                                Converted = "No"
                            }
                            
                                );


                    }
                    if (!context.Others.Any())
                    {
                        context.Others.AddRange(
                            new Other
                            {
                                Name = "Whey",
                                Lease = "No",
                                Asset = "Building",
                                InvestmentValue = 50000000,
                                TeamMembers = "Somandla",
                                Status = " Project Appoved By DG Board"
                            });

                    }
                    if (!context.WildCoasts.Any())
                    {
                        context.WildCoasts.AddRange(
                            new WildCoast
                            {
                                Name = "AAP Industries",
                                Lease = "No",
                                Asset = "building",
                                InvestmentValue = 380000000,
                                TeamMembers = "SimphiweS",
                                Status = " Project not sure"
                            });

                    }

                }
                context.SaveChanges();
            }
        }
    }
}
