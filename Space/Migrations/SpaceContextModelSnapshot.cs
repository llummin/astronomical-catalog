﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Space.Models;

#nullable disable

namespace Space.Migrations
{
    [DbContext(typeof(SpaceContext))]
    partial class SpaceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Space.Models.Asteroids", b =>
                {
                    b.Property<int>("AstId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ast_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AstId"));

                    b.Property<double?>("AstArgumentOfPerihelion")
                        .HasColumnType("float")
                        .HasColumnName("ast_argument_of_perihelion");

                    b.Property<int?>("AstDiameter")
                        .HasColumnType("int")
                        .HasColumnName("ast_diameter");

                    b.Property<double?>("AstMeanAnomaly")
                        .HasColumnType("float")
                        .HasColumnName("ast_mean_anomaly");

                    b.Property<string>("AstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ast_name");

                    b.Property<double?>("AstOrbitalEccentricity")
                        .HasColumnType("float")
                        .HasColumnName("ast_orbital_eccentricity");

                    b.Property<double?>("AstOrbitalInclination")
                        .HasColumnType("float")
                        .HasColumnName("ast_orbital_inclination");

                    b.Property<int?>("StarId")
                        .HasColumnType("int")
                        .HasColumnName("star_id");

                    b.HasKey("AstId");

                    b.HasIndex("StarId");

                    b.HasIndex(new[] { "AstName" }, "UQ__Asteroids_ast_name")
                        .IsUnique();

                    b.ToTable("Asteroids");
                });

            modelBuilder.Entity("Space.Models.BlackHoles", b =>
                {
                    b.Property<int>("BlackHoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("blackHole_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlackHoleId"));

                    b.Property<string>("BlackholeDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("blackhole_declination");

                    b.Property<double?>("BlackholeDistance")
                        .HasColumnType("float")
                        .HasColumnName("blackhole_distance");

                    b.Property<string>("BlackholeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("blackhole_name");

                    b.Property<TimeSpan?>("BlackholeRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("blackhole_right_ascension");

                    b.Property<string>("BlackholeType")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("blackhole_type");

                    b.Property<int>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("int")
                        .HasColumnName("glx_id");

                    b.HasKey("BlackHoleId");

                    b.HasIndex("ConsId");

                    b.HasIndex("GlxId");

                    b.HasIndex(new[] { "BlackholeName" }, "UQ__BlackHoles_blackhole_name")
                        .IsUnique();

                    b.ToTable("BlackHoles");
                });

            modelBuilder.Entity("Space.Models.Comets", b =>
                {
                    b.Property<int>("CometId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("comet_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CometId"));

                    b.Property<double?>("CometEccentricity")
                        .HasColumnType("float")
                        .HasColumnName("comet_eccentricity");

                    b.Property<string>("CometName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("comet_name");

                    b.Property<double?>("CometOrbitalInclination")
                        .HasColumnType("float")
                        .HasColumnName("comet_orbital_inclination");

                    b.Property<double?>("CometOrbitalPeriod")
                        .HasColumnType("float")
                        .HasColumnName("comet_orbital_period");

                    b.Property<double?>("CometPerihelion")
                        .HasColumnType("float")
                        .HasColumnName("comet_perihelion");

                    b.Property<double?>("CometSemiMajorAxis")
                        .HasColumnType("float")
                        .HasColumnName("comet_semi_major_axis");

                    b.Property<int?>("StarId")
                        .HasColumnType("int")
                        .HasColumnName("star_id");

                    b.HasKey("CometId");

                    b.HasIndex("StarId");

                    b.HasIndex(new[] { "CometName" }, "UQ__Comets__comet_name")
                        .IsUnique();

                    b.ToTable("Comets");
                });

            modelBuilder.Entity("Space.Models.Constellations", b =>
                {
                    b.Property<int>("ConsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsId"));

                    b.Property<string>("ConsAbbreviation")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("cons_abbreviation");

                    b.Property<string>("ConsDeclination")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("cons_declination");

                    b.Property<string>("ConsImage")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cons_image");

                    b.Property<string>("ConsName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cons_name");

                    b.Property<string>("ConsRightAscension")
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)")
                        .HasColumnName("cons_right_ascension");

                    b.Property<int?>("ConsSquare")
                        .HasColumnType("int")
                        .HasColumnName("cons_square");

                    b.Property<string>("ConsSymbolism")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("nvarchar(22)")
                        .HasColumnName("cons_symbolism");

                    b.Property<string>("ConsVisibleInLatitudes")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("cons_visible_in_latitudes");

                    b.HasKey("ConsId");

                    b.HasIndex(new[] { "ConsAbbreviation" }, "UQ_Constellations_cons_abbreviation")
                        .IsUnique();

                    b.HasIndex(new[] { "ConsName" }, "UQ_Constellations_cons_name")
                        .IsUnique();

                    b.HasIndex(new[] { "ConsSymbolism" }, "UQ_Constellations_cons_symbolism")
                        .IsUnique();

                    b.ToTable("Constellations");
                });

            modelBuilder.Entity("Space.Models.Galaxies", b =>
                {
                    b.Property<int>("GlxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("glx_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GlxId"));

                    b.Property<int?>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<double?>("GlxApparentMagnitude")
                        .HasColumnType("float")
                        .HasColumnName("glx_apparent_magnitude");

                    b.Property<string>("GlxDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("glx_declination");

                    b.Property<int?>("GlxDistance")
                        .HasColumnType("int")
                        .HasColumnName("glx_distance");

                    b.Property<string>("GlxImage")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("glx_image");

                    b.Property<string>("GlxName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("glx_name");

                    b.Property<int?>("GlxRadialVelocity")
                        .HasColumnType("int")
                        .HasColumnName("glx_radial_velocity");

                    b.Property<double?>("GlxRadius")
                        .HasColumnType("float")
                        .HasColumnName("glx_radius");

                    b.Property<double?>("GlxRedshift")
                        .HasColumnType("float")
                        .HasColumnName("glx_redshift");

                    b.Property<TimeSpan?>("GlxRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("glx_right_ascension");

                    b.Property<string>("GlxType")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("glx_type");

                    b.Property<int?>("GlxclusterId")
                        .HasColumnType("int")
                        .HasColumnName("glxcluster_id");

                    b.Property<int?>("GlxgroupId")
                        .HasColumnType("int")
                        .HasColumnName("glxgroup_id");

                    b.HasKey("GlxId")
                        .HasName("PK__Galaxies");

                    b.HasIndex("ConsId");

                    b.HasIndex("GlxclusterId");

                    b.HasIndex("GlxgroupId");

                    b.HasIndex(new[] { "GlxName" }, "UQ_Galaxies_glx_name")
                        .IsUnique();

                    b.ToTable("Galaxies");
                });

            modelBuilder.Entity("Space.Models.GalaxyClusters", b =>
                {
                    b.Property<int>("GlxclusterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("glxcluster_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GlxclusterId"));

                    b.Property<int>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<string>("GlxclusterDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("glxcluster_declination");

                    b.Property<string>("GlxclusterImage")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("glxcluster_image");

                    b.Property<string>("GlxclusterName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("glxcluster_name");

                    b.Property<double?>("GlxclusterRedshift")
                        .HasColumnType("float")
                        .HasColumnName("glxcluster_redshift");

                    b.Property<TimeSpan?>("GlxclusterRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("glxcluster_right_ascension");

                    b.Property<string>("GlxclusterType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("glxcluster_type");

                    b.HasKey("GlxclusterId");

                    b.HasIndex("ConsId");

                    b.HasIndex(new[] { "GlxclusterName" }, "UQ_GalaxyClusters_glxcluster_name")
                        .IsUnique();

                    b.ToTable("GalaxyClusters");
                });

            modelBuilder.Entity("Space.Models.GalaxyGroups", b =>
                {
                    b.Property<int>("GlxgroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("glxgroup_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GlxgroupId"));

                    b.Property<int?>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<string>("GlxgroupDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("glxgroup_declination");

                    b.Property<string>("GlxgroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("glxgroup_name");

                    b.Property<double?>("GlxgroupRedshift")
                        .HasColumnType("float")
                        .HasColumnName("glxgroup_redshift");

                    b.Property<TimeSpan?>("GlxgroupRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("glxgroup_right_ascension");

                    b.Property<string>("GlxgroupType")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("glxgroup_type");

                    b.Property<string>("GlxgroupImage")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("glxgroup_image");

                    b.HasKey("GlxgroupId");

                    b.HasIndex("ConsId");

                    b.HasIndex(new[] { "GlxgroupName" }, "UQ_GalaxyGroups_glxgroup_name")
                        .IsUnique();

                    b.ToTable("GalaxyGroups");
                });

            modelBuilder.Entity("Space.Models.Nebulae", b =>
                {
                    b.Property<int>("NebulaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("nebula_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NebulaId"));

                    b.Property<int>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("int")
                        .HasColumnName("glx_id");

                    b.Property<string>("NebulaDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("nebula_declination");

                    b.Property<int?>("NebulaDistance")
                        .HasColumnType("int")
                        .HasColumnName("nebula_distance");

                    b.Property<string>("NebulaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nebula_name");

                    b.Property<TimeSpan?>("NebulaRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("nebula_right_ascension");

                    b.Property<string>("NebulaType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("nebula_type");

                    b.HasKey("NebulaId")
                        .HasName("PK__Nebulae");

                    b.HasIndex("ConsId");

                    b.HasIndex("GlxId");

                    b.HasIndex(new[] { "NebulaName" }, "UQ_Nebulae_nebula_name")
                        .IsUnique();

                    b.ToTable("Nebulae");
                });

            modelBuilder.Entity("Space.Models.PlanetarySystems", b =>
                {
                    b.Property<int>("PlanetsystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("planetsystem_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanetsystemId"));

                    b.Property<int?>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("int")
                        .HasColumnName("glx_id");

                    b.Property<byte>("PlanetsystemConfirmedPlanets")
                        .HasColumnType("tinyint")
                        .HasColumnName("planetsystem_confirmed_planets");

                    b.Property<string>("PlanetsystemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("planetsystem_name");

                    b.HasKey("PlanetsystemId");

                    b.HasIndex("ConsId");

                    b.HasIndex("GlxId");

                    b.HasIndex(new[] { "PlanetsystemName" }, "UQ_PlanetarySystems_planetsystem_name")
                        .IsUnique();

                    b.ToTable("PlanetarySystems");
                });

            modelBuilder.Entity("Space.Models.Planets", b =>
                {
                    b.Property<int>("PlntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("plnt_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlntId"));

                    b.Property<int?>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<double?>("PlntArgumentOfPerihelion")
                        .HasColumnType("float")
                        .HasColumnName("plnt_argument_of_perihelion");

                    b.Property<double?>("PlntEccentricity")
                        .HasColumnType("float")
                        .HasColumnName("plnt_eccentricity");

                    b.Property<double?>("PlntMass")
                        .HasColumnType("float")
                        .HasColumnName("plnt_mass");

                    b.Property<string>("PlntName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("plnt_name");

                    b.Property<double?>("PlntOrbitalPeriod")
                        .HasColumnType("float")
                        .HasColumnName("plnt_orbital_period");

                    b.Property<double?>("PlntSemiMajorAxis")
                        .HasColumnType("float")
                        .HasColumnName("plnt_semi_major_axis");

                    b.Property<int?>("StarId")
                        .HasColumnType("int")
                        .HasColumnName("star_id");

                    b.HasKey("PlntId");

                    b.HasIndex("ConsId");

                    b.HasIndex("StarId");

                    b.HasIndex(new[] { "PlntName" }, "UQ_Planets_exo_name")
                        .IsUnique();

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("Space.Models.StarClusters", b =>
                {
                    b.Property<int>("StarclusterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("starcluster_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StarclusterId"));

                    b.Property<int?>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("int")
                        .HasColumnName("glx_id");

                    b.Property<int?>("StarclusterAge")
                        .HasColumnType("int")
                        .HasColumnName("starcluster_age");

                    b.Property<string>("StarclusterDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("starcluster_declination");

                    b.Property<double?>("StarclusterDiameter")
                        .HasColumnType("float")
                        .HasColumnName("starcluster_diameter");

                    b.Property<double?>("StarclusterDistance")
                        .HasColumnType("float")
                        .HasColumnName("starcluster_distance");

                    b.Property<string>("StarclusterName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("starcluster_name");

                    b.Property<TimeSpan?>("StarclusterRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("starcluster_right_ascension");

                    b.Property<string>("StarclusterType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("starcluster_type");

                    b.HasKey("StarclusterId");

                    b.HasIndex("ConsId");

                    b.HasIndex("GlxId");

                    b.HasIndex(new[] { "StarclusterName" }, "UQ_StarClusters_starcluster_name")
                        .IsUnique();

                    b.ToTable("StarClusters");
                });

            modelBuilder.Entity("Space.Models.Stars", b =>
                {
                    b.Property<int>("StarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("star_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StarId"));

                    b.Property<int?>("ConsId")
                        .HasColumnType("int")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("int")
                        .HasColumnName("glx_id");

                    b.Property<int?>("PlanetsystemId")
                        .HasColumnType("int")
                        .HasColumnName("planetsystem_id");

                    b.Property<double?>("StarApparentMagnitude")
                        .HasColumnType("float")
                        .HasColumnName("star_apparent_magnitude");

                    b.Property<string>("StarDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("star_declination");

                    b.Property<double?>("StarDistance")
                        .HasColumnType("float")
                        .HasColumnName("star_distance");

                    b.Property<string>("StarName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("star_name");

                    b.Property<string>("StarStellarClass")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("star_stellar_class");

                    b.Property<int?>("StarclusterId")
                        .HasColumnType("int")
                        .HasColumnName("starcluster_id");

                    b.HasKey("StarId");

                    b.HasIndex("ConsId");

                    b.HasIndex("GlxId");

                    b.HasIndex("PlanetsystemId");

                    b.HasIndex("StarclusterId");

                    b.HasIndex(new[] { "StarName" }, "UQ_Stars_star_name")
                        .IsUnique();

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("Space.Models.Asteroids", b =>
                {
                    b.HasOne("Space.Models.Stars", "Star")
                        .WithMany("Asteroids")
                        .HasForeignKey("StarId")
                        .HasConstraintName("FK_Asteroids_Stars");

                    b.Navigation("Star");
                });

            modelBuilder.Entity("Space.Models.BlackHoles", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("BlackHoles")
                        .HasForeignKey("ConsId")
                        .IsRequired()
                        .HasConstraintName("FK_BlackHoles_To_Constellations");

                    b.HasOne("Space.Models.Galaxies", "Glx")
                        .WithMany("BlackHoles")
                        .HasForeignKey("GlxId")
                        .HasConstraintName("FK_BlackHoles_To_Galaxies");

                    b.Navigation("Cons");

                    b.Navigation("Glx");
                });

            modelBuilder.Entity("Space.Models.Comets", b =>
                {
                    b.HasOne("Space.Models.Stars", "Star")
                        .WithMany("Comets")
                        .HasForeignKey("StarId")
                        .HasConstraintName("FK_Comets_Stars");

                    b.Navigation("Star");
                });

            modelBuilder.Entity("Space.Models.Galaxies", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("Galaxies")
                        .HasForeignKey("ConsId")
                        .HasConstraintName("FK_Galaxies_To_Constellations");

                    b.HasOne("Space.Models.GalaxyClusters", "Glxcluster")
                        .WithMany("Galaxies")
                        .HasForeignKey("GlxclusterId")
                        .HasConstraintName("FK_Galaxies_To_GalaxyClusters");

                    b.HasOne("Space.Models.GalaxyGroups", "Glxgroup")
                        .WithMany("Galaxies")
                        .HasForeignKey("GlxgroupId")
                        .HasConstraintName("FK_Galaxies_To_GalaxyGroups");

                    b.Navigation("Cons");

                    b.Navigation("Glxcluster");

                    b.Navigation("Glxgroup");
                });

            modelBuilder.Entity("Space.Models.GalaxyClusters", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("GalaxyClusters")
                        .HasForeignKey("ConsId")
                        .IsRequired()
                        .HasConstraintName("FK_GalaxyClusters_To_Constellations");

                    b.Navigation("Cons");
                });

            modelBuilder.Entity("Space.Models.GalaxyGroups", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("GalaxyGroups")
                        .HasForeignKey("ConsId")
                        .HasConstraintName("FK_GalaxyGroups_To_Constellations");

                    b.Navigation("Cons");
                });

            modelBuilder.Entity("Space.Models.Nebulae", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("Nebulae")
                        .HasForeignKey("ConsId")
                        .IsRequired()
                        .HasConstraintName("FK_Nebulae_To_Constellations");

                    b.HasOne("Space.Models.Galaxies", "Glx")
                        .WithMany("Nebulae")
                        .HasForeignKey("GlxId")
                        .HasConstraintName("FK_Nebulae_Galaxies");

                    b.Navigation("Cons");

                    b.Navigation("Glx");
                });

            modelBuilder.Entity("Space.Models.PlanetarySystems", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("PlanetarySystems")
                        .HasForeignKey("ConsId")
                        .HasConstraintName("FK_PlanetarySystems_To_Constellations");

                    b.HasOne("Space.Models.Galaxies", "Glx")
                        .WithMany("PlanetarySystems")
                        .HasForeignKey("GlxId")
                        .HasConstraintName("FK_PlanetarySystems_Galaxies");

                    b.Navigation("Cons");

                    b.Navigation("Glx");
                });

            modelBuilder.Entity("Space.Models.Planets", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("Planets")
                        .HasForeignKey("ConsId")
                        .HasConstraintName("FK_Planets_To_Constellations");

                    b.HasOne("Space.Models.Stars", "Star")
                        .WithMany("Planets")
                        .HasForeignKey("StarId")
                        .HasConstraintName("FK_Planets_Stars");

                    b.Navigation("Cons");

                    b.Navigation("Star");
                });

            modelBuilder.Entity("Space.Models.StarClusters", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("StarClusters")
                        .HasForeignKey("ConsId")
                        .HasConstraintName("FK_StarClusters_To_Constellations");

                    b.HasOne("Space.Models.Galaxies", "Glx")
                        .WithMany("StarClusters")
                        .HasForeignKey("GlxId")
                        .HasConstraintName("FK_StarClusters_Galaxies");

                    b.Navigation("Cons");

                    b.Navigation("Glx");
                });

            modelBuilder.Entity("Space.Models.Stars", b =>
                {
                    b.HasOne("Space.Models.Constellations", "Cons")
                        .WithMany("Stars")
                        .HasForeignKey("ConsId")
                        .HasConstraintName("FK_Stars_Constellations");

                    b.HasOne("Space.Models.Galaxies", "Glx")
                        .WithMany("Stars")
                        .HasForeignKey("GlxId")
                        .HasConstraintName("FK_Stars_To_Galaxies");

                    b.HasOne("Space.Models.PlanetarySystems", "Planetsystem")
                        .WithMany("Stars")
                        .HasForeignKey("PlanetsystemId")
                        .HasConstraintName("FK_Stars_To_PlanetarySystems");

                    b.HasOne("Space.Models.StarClusters", "Starcluster")
                        .WithMany("Stars")
                        .HasForeignKey("StarclusterId")
                        .HasConstraintName("FK_Stars_To_StarClusters");

                    b.Navigation("Cons");

                    b.Navigation("Glx");

                    b.Navigation("Planetsystem");

                    b.Navigation("Starcluster");
                });

            modelBuilder.Entity("Space.Models.Constellations", b =>
                {
                    b.Navigation("BlackHoles");

                    b.Navigation("Galaxies");

                    b.Navigation("GalaxyClusters");

                    b.Navigation("GalaxyGroups");

                    b.Navigation("Nebulae");

                    b.Navigation("PlanetarySystems");

                    b.Navigation("Planets");

                    b.Navigation("StarClusters");

                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Space.Models.Galaxies", b =>
                {
                    b.Navigation("BlackHoles");

                    b.Navigation("Nebulae");

                    b.Navigation("PlanetarySystems");

                    b.Navigation("StarClusters");

                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Space.Models.GalaxyClusters", b =>
                {
                    b.Navigation("Galaxies");
                });

            modelBuilder.Entity("Space.Models.GalaxyGroups", b =>
                {
                    b.Navigation("Galaxies");
                });

            modelBuilder.Entity("Space.Models.PlanetarySystems", b =>
                {
                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Space.Models.StarClusters", b =>
                {
                    b.Navigation("Stars");
                });

            modelBuilder.Entity("Space.Models.Stars", b =>
                {
                    b.Navigation("Asteroids");

                    b.Navigation("Comets");

                    b.Navigation("Planets");
                });
#pragma warning restore 612, 618
        }
    }
}
