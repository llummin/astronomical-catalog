﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Space.Models.Asteroids", b =>
                {
                    b.Property<int>("AstId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ast_id");

                    b.Property<double?>("AstArgumentOfPerihelion")
                        .HasColumnType("REAL")
                        .HasColumnName("ast_argument_of_perihelion");

                    b.Property<int?>("AstDiameter")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ast_diameter");

                    b.Property<double?>("AstMeanAnomaly")
                        .HasColumnType("REAL")
                        .HasColumnName("ast_mean_anomaly");

                    b.Property<string>("AstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("ast_name");

                    b.Property<double?>("AstOrbitalEccentricity")
                        .HasColumnType("REAL")
                        .HasColumnName("ast_orbital_eccentricity");

                    b.Property<double?>("AstOrbitalInclination")
                        .HasColumnType("REAL")
                        .HasColumnName("ast_orbital_inclination");

                    b.Property<int?>("StarId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("blackHole_id");

                    b.Property<string>("BlackholeDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("blackhole_declination");

                    b.Property<double?>("BlackholeDistance")
                        .HasColumnType("REAL")
                        .HasColumnName("blackhole_distance");

                    b.Property<string>("BlackholeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("blackhole_name");

                    b.Property<TimeSpan?>("BlackholeRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("blackhole_right_ascension");

                    b.Property<string>("BlackholeType")
                        .HasMaxLength(14)
                        .HasColumnType("TEXT")
                        .HasColumnName("blackhole_type");

                    b.Property<int>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("comet_id");

                    b.Property<double?>("CometEccentricity")
                        .HasColumnType("REAL")
                        .HasColumnName("comet_eccentricity");

                    b.Property<string>("CometName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("comet_name");

                    b.Property<double?>("CometOrbitalInclination")
                        .HasColumnType("REAL")
                        .HasColumnName("comet_orbital_inclination");

                    b.Property<double?>("CometOrbitalPeriod")
                        .HasColumnType("REAL")
                        .HasColumnName("comet_orbital_period");

                    b.Property<double?>("CometPerihelion")
                        .HasColumnType("REAL")
                        .HasColumnName("comet_perihelion");

                    b.Property<double?>("CometSemiMajorAxis")
                        .HasColumnType("REAL")
                        .HasColumnName("comet_semi_major_axis");

                    b.Property<int?>("StarId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<string>("ConsName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("cons_name");

                    b.Property<string>("ConsAbbreviation")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT")
                        .HasColumnName("cons_abbreviation");

                    b.Property<string>("ConsDeclination")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT")
                        .HasColumnName("cons_declination");

                    b.Property<string>("ConsRightAscension")
                        .HasMaxLength(17)
                        .HasColumnType("TEXT")
                        .HasColumnName("cons_right_ascension");

                    b.Property<int?>("ConsSquare")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_square");

                    b.Property<string>("ConsSymbolism")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("TEXT")
                        .HasColumnName("cons_symbolism");

                    b.Property<string>("ConsVisibleInLatitudes")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT")
                        .HasColumnName("cons_visible_in_latitudes");

                    b.HasKey("ConsId");

                    b.HasIndex(new[] { "ConsName" }, "UQ_Constellations_cons_name")
                        .IsUnique();

                    b.HasIndex(new[] { "ConsAbbreviation" }, "UQ_Constellations_cons_abbreviation")
                        .IsUnique();

                    b.HasIndex(new[] { "ConsSymbolism" }, "UQ_Constellations_cons_symbolism")
                        .IsUnique();

                    b.ToTable("Constellations");
                });

            modelBuilder.Entity("Space.Models.Galaxies", b =>
                {
                    b.Property<int>("GlxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("glx_id");

                    b.Property<int?>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<double?>("GlxApparentMagnitude")
                        .HasColumnType("REAL")
                        .HasColumnName("glx_apparent_magnitude");

                    b.Property<string>("GlxDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("glx_declination");

                    b.Property<int?>("GlxDistance")
                        .HasColumnType("INTEGER")
                        .HasColumnName("glx_distance");

                    b.Property<string>("GlxName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("glx_name");

                    b.Property<int?>("GlxRadialVelocity")
                        .HasColumnType("INTEGER")
                        .HasColumnName("glx_radial_velocity");

                    b.Property<double?>("GlxRadius")
                        .HasColumnType("REAL")
                        .HasColumnName("glx_radius");

                    b.Property<double?>("GlxRedshift")
                        .HasColumnType("REAL")
                        .HasColumnName("glx_redshift");

                    b.Property<TimeSpan?>("GlxRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("glx_right_ascension");

                    b.Property<string>("GlxType")
                        .HasMaxLength(14)
                        .HasColumnType("TEXT")
                        .HasColumnName("glx_type");

                    b.Property<int?>("GlxclusterId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("glxcluster_id");

                    b.Property<int?>("GlxgroupId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("glxcluster_id");

                    b.Property<int>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<string>("GlxclusterDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("glxcluster_declination");

                    b.Property<string>("GlxclusterName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("glxcluster_name");

                    b.Property<double?>("GlxclusterRedshift")
                        .HasColumnType("REAL")
                        .HasColumnName("glxcluster_redshift");

                    b.Property<TimeSpan?>("GlxclusterRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("glxcluster_right_ascension");

                    b.Property<string>("GlxclusterType")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("glxgroup_id");

                    b.Property<int?>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<string>("GlxgroupDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("glxgroup_declination");

                    b.Property<string>("GlxgroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("glxgroup_name");

                    b.Property<double?>("GlxgroupRedshift")
                        .HasColumnType("REAL")
                        .HasColumnName("glxgroup_redshift");

                    b.Property<TimeSpan?>("GlxgroupRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("glxgroup_right_ascension");

                    b.Property<string>("GlxgroupType")
                        .HasMaxLength(11)
                        .HasColumnType("TEXT")
                        .HasColumnName("glxgroup_type");

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
                        .HasColumnType("INTEGER")
                        .HasColumnName("nebula_id");

                    b.Property<int>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("glx_id");

                    b.Property<string>("NebulaDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("nebula_declination");

                    b.Property<int?>("NebulaDistance")
                        .HasColumnType("INTEGER")
                        .HasColumnName("nebula_distance");

                    b.Property<string>("NebulaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("nebula_name");

                    b.Property<TimeSpan?>("NebulaRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("nebula_right_ascension");

                    b.Property<string>("NebulaType")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("planetsystem_id");

                    b.Property<int?>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("glx_id");

                    b.Property<byte>("PlanetsystemConfirmedPlanets")
                        .HasColumnType("INTEGER")
                        .HasColumnName("planetsystem_confirmed_planets");

                    b.Property<string>("PlanetsystemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("plnt_id");

                    b.Property<int?>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<double?>("PlntArgumentOfPerihelion")
                        .HasColumnType("REAL")
                        .HasColumnName("plnt_argument_of_perihelion");

                    b.Property<double?>("PlntEccentricity")
                        .HasColumnType("REAL")
                        .HasColumnName("plnt_eccentricity");

                    b.Property<double?>("PlntMass")
                        .HasColumnType("REAL")
                        .HasColumnName("plnt_mass");

                    b.Property<string>("PlntName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("plnt_name");

                    b.Property<double?>("PlntOrbitalPeriod")
                        .HasColumnType("REAL")
                        .HasColumnName("plnt_orbital_period");

                    b.Property<double?>("PlntSemiMajorAxis")
                        .HasColumnType("REAL")
                        .HasColumnName("plnt_semi_major_axis");

                    b.Property<int?>("StarId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("starcluster_id");

                    b.Property<int?>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("glx_id");

                    b.Property<int?>("StarclusterAge")
                        .HasColumnType("INTEGER")
                        .HasColumnName("starcluster_age");

                    b.Property<string>("StarclusterDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("starcluster_declination");

                    b.Property<double?>("StarclusterDiameter")
                        .HasColumnType("REAL")
                        .HasColumnName("starcluster_diameter");

                    b.Property<double?>("StarclusterDistance")
                        .HasColumnType("REAL")
                        .HasColumnName("starcluster_distance");

                    b.Property<string>("StarclusterName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("starcluster_name");

                    b.Property<TimeSpan?>("StarclusterRightAscension")
                        .HasColumnType("time(0)")
                        .HasColumnName("starcluster_right_ascension");

                    b.Property<string>("StarclusterType")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("star_id");

                    b.Property<int?>("ConsId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cons_id");

                    b.Property<int?>("GlxId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("glx_id");

                    b.Property<int?>("PlanetsystemId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("planetsystem_id");

                    b.Property<double?>("StarApparentMagnitude")
                        .HasColumnType("REAL")
                        .HasColumnName("star_apparent_magnitude");

                    b.Property<string>("StarDeclination")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("star_declination");

                    b.Property<double?>("StarDistance")
                        .HasColumnType("REAL")
                        .HasColumnName("star_distance");

                    b.Property<string>("StarName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("star_name");

                    b.Property<string>("StarStellarClass")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("star_stellar_class");

                    b.Property<int?>("StarclusterId")
                        .HasColumnType("INTEGER")
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
