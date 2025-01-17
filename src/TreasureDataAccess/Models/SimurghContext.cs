using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TreasureDataAccess.Models;

public partial class SimurghContext : DbContext
{
    public SimurghContext()
    {
    }

    public SimurghContext(DbContextOptions<SimurghContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DataLead> DataLeads { get; set; }

    public virtual DbSet<MstApplicationDescription> MstApplicationDescriptions { get; set; }

    public virtual DbSet<MstApplicationType> MstApplicationTypes { get; set; }

    public virtual DbSet<MstBank> MstBanks { get; set; }

    public virtual DbSet<MstBranch> MstBranches { get; set; }

    public virtual DbSet<MstBrand> MstBrands { get; set; }

    public virtual DbSet<MstBrandType> MstBrandTypes { get; set; }

    public virtual DbSet<MstCategory> MstCategories { get; set; }

    public virtual DbSet<MstDistrict> MstDistricts { get; set; }

    public virtual DbSet<MstIdentity> MstIdentities { get; set; }

    public virtual DbSet<MstModel> MstModels { get; set; }

    public virtual DbSet<MstPaymentOfTerm> MstPaymentOfTerms { get; set; }

    public virtual DbSet<MstProduct> MstProducts { get; set; }

    public virtual DbSet<MstProvince> MstProvinces { get; set; }

    public virtual DbSet<MstSubdistrict> MstSubdistricts { get; set; }

    public virtual DbSet<MstSurveyor> MstSurveyors { get; set; }

    public virtual DbSet<MstType> MstTypes { get; set; }

    public virtual DbSet<MstVariety> MstVarieties { get; set; }

    public virtual DbSet<MstVillage> MstVillages { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseSqlServer("Server=0.tcp.ap.ngrok.io,11908;Database=simurgh;User Id=sa;Password=yourStrong(!)Password;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DataLead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__data_lea__3213E83F0961E81B");

            entity.ToTable("data_leads");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.ApplicationDescriptionId).HasColumnName("application_description_id");
            entity.Property(e => e.ApplicationSource)
                .HasMaxLength(255)
                .HasColumnName("application_source");
            entity.Property(e => e.ApplicationTypeId).HasColumnName("application_type_id");
            entity.Property(e => e.BpkbNumber)
                .HasMaxLength(255)
                .HasColumnName("bpkb_number");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.DebtorsType)
                .HasMaxLength(255)
                .HasColumnName("debtors_type");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DomicileAddress)
                .HasMaxLength(255)
                .HasColumnName("domicile_address");
            entity.Property(e => e.DomicilleVillageId).HasColumnName("domicille_village_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .HasColumnName("gender");
            entity.Property(e => e.IdentityId).HasColumnName("identity_id");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("middle_name");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(255)
                .HasColumnName("partner_id");
            entity.Property(e => e.PaymentOfTermId).HasColumnName("payment_of_term_id");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(255)
                .HasColumnName("phone_number");
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(255)
                .HasColumnName("phone_number_2");
            entity.Property(e => e.PoliceNumber)
                .HasMaxLength(255)
                .HasColumnName("police_number");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("reference");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SurveyorId).HasColumnName("surveyor_id");
            entity.Property(e => e.TaxYear).HasColumnName("tax_year");
            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .HasColumnName("telephone");
            entity.Property(e => e.TypeOfBusiness)
                .HasMaxLength(255)
                .HasColumnName("type_of_business");
            entity.Property(e => e.VillageId).HasColumnName("village_id");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.ApplicationDescription).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.ApplicationDescriptionId)
                .HasConstraintName("FK__data_lead__appli__7C4F7684");

            entity.HasOne(d => d.ApplicationType).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.ApplicationTypeId)
                .HasConstraintName("FK__data_lead__appli__76969D2E");

            entity.HasOne(d => d.Branch).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__data_lead__branc__7A672E12");

            entity.HasOne(d => d.Category).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__data_lead__categ__7F2BE32F");

            entity.HasOne(d => d.DomicilleVillage).WithMany(p => p.DataLeadDomicilleVillages)
                .HasForeignKey(d => d.DomicilleVillageId)
                .HasConstraintName("FK__data_lead__domic__797309D9");

            entity.HasOne(d => d.Identity).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.IdentityId)
                .HasConstraintName("FK__data_lead__ident__778AC167");

            entity.HasOne(d => d.Partner).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__data_lead__partn__7B5B524B");

            entity.HasOne(d => d.PaymentOfTerm).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.PaymentOfTermId)
                .HasConstraintName("FK__data_lead__payme__7E37BEF6");

            entity.HasOne(d => d.Product).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__data_lead__produ__75A278F5");

            entity.HasOne(d => d.Surveyor).WithMany(p => p.DataLeads)
                .HasForeignKey(d => d.SurveyorId)
                .HasConstraintName("FK__data_lead__surve__7D439ABD");

            entity.HasOne(d => d.Village).WithMany(p => p.DataLeadVillages)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK__data_lead__villa__787EE5A0");
        });

        modelBuilder.Entity<MstApplicationDescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_appl__3213E83F21D5D8A9");

            entity.ToTable("mst_application_description");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstApplicationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_appl__3213E83F25B13D1D");

            entity.ToTable("mst_application_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_bank__3213E83FD636C200");

            entity.ToTable("mst_bank");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_bran__3213E83FE8B88532");

            entity.ToTable("mst_branch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.CoaRakNumber)
                .HasMaxLength(255)
                .HasColumnName("coa_rak_number");
            entity.Property(e => e.CustodianCode)
                .HasMaxLength(255)
                .HasColumnName("custodian_code");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.LocalTime)
                .HasMaxLength(50)
                .HasColumnName("local_time");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NpwpNumber)
                .HasMaxLength(255)
                .HasColumnName("npwp_number");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(255)
                .HasColumnName("phone_number");
            entity.Property(e => e.PicTitle)
                .HasMaxLength(255)
                .HasColumnName("pic_title");
            entity.Property(e => e.PlafonCashAdvance)
                .HasColumnType("money")
                .HasColumnName("plafon_cash_advance");
            entity.Property(e => e.PlafonFunding)
                .HasColumnType("money")
                .HasColumnName("plafon_funding");
            entity.Property(e => e.PlafonPettyCash)
                .HasColumnType("money")
                .HasColumnName("plafon_petty_cash");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Structure)
                .HasMaxLength(255)
                .HasColumnName("structure");
            entity.Property(e => e.VillageId).HasColumnName("village_id");

            entity.HasOne(d => d.Product).WithMany(p => p.MstBranches)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__mst_branc__produ__5CD6CB2B");

            entity.HasOne(d => d.Village).WithMany(p => p.MstBranches)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK__mst_branc__villa__5BE2A6F2");
        });

        modelBuilder.Entity<MstBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_bran__3213E83F05FEAFAE");

            entity.ToTable("mst_brand");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.ManufacturerCountry)
                .HasMaxLength(255)
                .HasColumnName("manufacturer_country");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Category).WithMany(p => p.MstBrands)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__mst_brand__categ__66603565");
        });

        modelBuilder.Entity<MstBrandType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_bran__3213E83F73731019");

            entity.ToTable("mst_brand_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.ManufacturerCountry)
                .HasMaxLength(255)
                .HasColumnName("manufacturer_country");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VarietyId).HasColumnName("variety_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.MstBrandTypes)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__mst_brand__brand__6D0D32F4");

            entity.HasOne(d => d.Category).WithMany(p => p.MstBrandTypes)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__mst_brand__categ__6C190EBB");

            entity.HasOne(d => d.Variety).WithMany(p => p.MstBrandTypes)
                .HasForeignKey(d => d.VarietyId)
                .HasConstraintName("FK__mst_brand__varie__6E01572D");
        });

        modelBuilder.Entity<MstCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_cate__3213E83F509734EF");

            entity.ToTable("mst_category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstDistrict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_dist__3213E83F7FB362EE");

            entity.ToTable("mst_district");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProvinceId).HasColumnName("province_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Province).WithMany(p => p.MstDistricts)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK__mst_distr__provi__5DCAEF64");
        });

        modelBuilder.Entity<MstIdentity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_iden__3213E83F9BE46776");

            entity.ToTable("mst_identity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_mode__3213E83F1A75B0C0");

            entity.ToTable("mst_model");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandTypeId).HasColumnName("brand_type_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VarietyId).HasColumnName("variety_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.MstModels)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__mst_model__brand__693CA210");

            entity.HasOne(d => d.BrandType).WithMany(p => p.MstModels)
                .HasForeignKey(d => d.BrandTypeId)
                .HasConstraintName("FK__mst_model__brand__6A30C649");

            entity.HasOne(d => d.Category).WithMany(p => p.MstModels)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__mst_model__categ__68487DD7");

            entity.HasOne(d => d.Variety).WithMany(p => p.MstModels)
                .HasForeignKey(d => d.VarietyId)
                .HasConstraintName("FK__mst_model__varie__6B24EA82");
        });

        modelBuilder.Entity<MstPaymentOfTerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_paym__3213E83FABD3A41F");

            entity.ToTable("mst_payment_of_term");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EffectiveRate).HasColumnName("effective_rate");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.FinalPrincipalPayment)
                .HasColumnType("money")
                .HasColumnName("final_principal_payment");
            entity.Property(e => e.InitialPrincipalPayment)
                .HasColumnType("money")
                .HasColumnName("initial_principal_payment");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tenure).HasColumnName("tenure");

            entity.HasOne(d => d.Product).WithMany(p => p.MstPaymentOfTerms)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__mst_payme__produ__6383C8BA");
        });

        modelBuilder.Entity<MstProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_prod__3213E83FE6EBD5CF");

            entity.ToTable("mst_product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstProvince>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_prov__3213E83F923424A6");

            entity.ToTable("mst_province");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstSubdistrict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_subd__3213E83F863B345D");

            entity.ToTable("mst_subdistrict");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DistrictId).HasColumnName("district_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProvinceId).HasColumnName("province_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.District).WithMany(p => p.MstSubdistricts)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK__mst_subdi__distr__5FB337D6");

            entity.HasOne(d => d.Province).WithMany(p => p.MstSubdistricts)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK__mst_subdi__provi__5EBF139D");
        });

        modelBuilder.Entity<MstSurveyor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_surv__3213E83F667CFBC9");

            entity.ToTable("mst_surveyor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(255)
                .HasColumnName("partner_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SurveyorDate).HasColumnName("surveyor_date");

            entity.HasOne(d => d.Partner).WithMany(p => p.MstSurveyors)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__mst_surve__partn__6477ECF3");

            entity.HasOne(d => d.Product).WithMany(p => p.MstSurveyors)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__mst_surve__produ__656C112C");
        });

        modelBuilder.Entity<MstType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_type__3213E83F7E8B4BFA");

            entity.ToTable("mst_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MstVariety>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_vari__3213E83F5E4969A9");

            entity.ToTable("mst_variety");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Category).WithMany(p => p.MstVarieties)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__mst_varie__categ__6754599E");
        });

        modelBuilder.Entity<MstVillage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mst_vill__3213E83F37A57E13");

            entity.ToTable("mst_village");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DistrictId).HasColumnName("district_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(255)
                .HasColumnName("postal_code");
            entity.Property(e => e.ProvinceId).HasColumnName("province_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubdistrictId).HasColumnName("subdistrict_id");

            entity.HasOne(d => d.District).WithMany(p => p.MstVillages)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK__mst_villa__distr__619B8048");

            entity.HasOne(d => d.Province).WithMany(p => p.MstVillages)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK__mst_villa__provi__60A75C0F");

            entity.HasOne(d => d.Subdistrict).WithMany(p => p.MstVillages)
                .HasForeignKey(d => d.SubdistrictId)
                .HasConstraintName("FK__mst_villa__subdi__628FA481");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__partner__3213E83FC036DA6B");

            entity.ToTable("partner");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.BankAccountName)
                .HasMaxLength(255)
                .HasColumnName("bank_account_name");
            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(255)
                .HasColumnName("bank_account_number");
            entity.Property(e => e.BankId).HasColumnName("bank_id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.BirthPlace)
                .HasMaxLength(255)
                .HasColumnName("birth_place");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DomicileAddress)
                .HasMaxLength(255)
                .HasColumnName("domicile_address");
            entity.Property(e => e.DomicilleVillageId).HasColumnName("domicille_village_id");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .HasColumnName("gender");
            entity.Property(e => e.IdentityId).HasColumnName("identity_id");
            entity.Property(e => e.NpwpNumber)
                .HasMaxLength(255)
                .HasColumnName("npwp_number");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(255)
                .HasColumnName("phone_number");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(255)
                .HasColumnName("telephone_number");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.VillageId).HasColumnName("village_id");

            entity.HasOne(d => d.Bank).WithMany(p => p.Partners)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("FK__partner__bank_id__74AE54BC");

            entity.HasOne(d => d.Branch).WithMany(p => p.Partners)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__partner__branch___70DDC3D8");

            entity.HasOne(d => d.DomicilleVillage).WithMany(p => p.PartnerDomicilleVillages)
                .HasForeignKey(d => d.DomicilleVillageId)
                .HasConstraintName("FK__partner__domicil__73BA3083");

            entity.HasOne(d => d.Identity).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdentityId)
                .HasConstraintName("FK__partner__identit__71D1E811");

            entity.HasOne(d => d.Product).WithMany(p => p.Partners)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__partner__product__6FE99F9F");

            entity.HasOne(d => d.Type).WithMany(p => p.Partners)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK__partner__type_id__6EF57B66");

            entity.HasOne(d => d.Village).WithMany(p => p.PartnerVillages)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK__partner__village__72C60C4A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
