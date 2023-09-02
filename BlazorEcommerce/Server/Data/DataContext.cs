﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = Guid.NewGuid(),
                     Title = "The Hitchhiker's Guide to the Galaxy",
                     Description = "The Hitchhiker's Guide to the Galaxy adalah buku pertama dari lima seri trilogi komedi fiksi ilmiah Hitchhiker's Guide to the Galaxy karya Douglas Adams (buku keenam ditulis oleh Eoin Colfer). Novel ini merupakan adaptasi dari empat bagian pertama seri radio dengan nama yang sama. Novel ini pertama diterbitkan di London tanggal 12 Oktober 1979.[2] Buku ini terjual 250.000 eksemplar dalam kurun tiga bulan setelah diluncurkan.[3]Judul novel ini diambil dari The Hitchhiker's Guide to the Galaxy,",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/id/b/bd/H2G2_UK_front_cover.jpg?20130311090701",
                     Price = 9.99
                 },
                 new Product
                 {
                     Id = Guid.NewGuid(),
                     Title = "Ready Player One",
                     Description = "Ready Player One is a 2018 American science fiction film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                     Price = 7.99
                 },
                 new Product
                 {
                     Id = Guid.NewGuid(),
                     Title = "Gods and Generals ",
                     Description = "Gods and Generals is a novel which serves as a prequel to Michael Shaara's 1974 Pulitzer Prize–winning work about the Battle of Gettysburg, The Killer Angels. Written by Jeffrey Shaara after his father Michael's death in 1988, the novel relates events from 1858 through 1863, during the American Civil War, ending just as the two armies march toward Gettysburg. Shaara also wrote The Last Full Measure, published in 2000, which follows the events presented in The Killer Angels.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/65/GandGbook.jpg",
                     Price = 8.99
                 }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
