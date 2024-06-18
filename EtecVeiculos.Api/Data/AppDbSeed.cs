using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EtecVeiculos.Api.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder modelBuilder)
    {
        #region TipoVeiculo
        List<TipoVeiculo> tipoVeiculos = [
            new(){
                Id = 1,
                Name = "Moto"
            },
            new(){
                Id = 2,
                Name = "Carro"
            },
            new(){
                Id = 3,
                Name = "Caminhão"
            }
        ];
        modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
        #endregion

        #region Marcas
        // incluir 3 marcas
        List<Marca> marcas = [
            new() {
                Id = 1,
                Nome = "Chevrolet"
            },
            new() {
                Id = 2,
                Nome = "Honda"
            },
            new() {
                Id = 3,
                Nome = "Volkswagen"
            }
        ];
        modelBuilder.Entity<Marca>().HasData(marcas);
        #endregion

        #region Modelo
        // incluir 2 modelos por marca
        List<Modelo> modelos = new(){
            new() {
                Id = 1,
                Nome = "Onix Plus LT",
                MarcaId = 1
            },
            new() {
                Id = 2,
                Nome = "Montana PREMIER",
                MarcaId = 1
            },
            new() {
                Id = 3,
                Nome = "Civic Type R",
                MarcaId = 2
            },
            new() {
                Id = 4,
                Nome ="New City Sedan",
                MarcaId = 2
            },
            new(){
                Id = 5,
                Nome = "Jetta",
                MarcaId = 3
            },
            new() {
                Id = 6,
                Nome = "Golf GTI",
                MarcaId = 3
            }            
        };
        modelBuilder.Entity<Modelo>().HasData(modelos);
        #endregion
    }
}
