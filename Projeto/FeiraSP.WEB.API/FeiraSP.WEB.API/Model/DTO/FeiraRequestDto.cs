﻿using System.ComponentModel.DataAnnotations;

namespace FeiraSP.WEB.API.Model.DTO
{
    /// <summary>
    /// Classe que representa os dados enviados na requisicao da API
    /// </summary>
    public class FeiraRequestDto
    {
        /// <summary>
        /// Identificado do Feira
        /// </summary>

        [Display(Name = "Identificador da Feira")]
        public int Id { get; set; }

        /// <summary>
        /// Logitude da Feira
        /// </summary>
        /// 
        [Required(ErrorMessage = "Informe o campo Logitude")]
        [Display(Name = "Longitude")]
        public int Longitude { get; set; }

        /// <summary>
        /// Latitude de Feira
        /// </summary>
        [Required(ErrorMessage = "Informe o campo Latitude")]
        [Display(Name = "Latitude")]
        public int Latitude { get; set; }

        /// <summary>
        /// SetCens da Feira
        /// </summary>
        [Required(ErrorMessage = "Informe o campo SetCens")]
        [Display(Name = "SetCens")]
        public long SetCens { get; set; }

        /// <summary>
        /// Area definida pela prefeitura
        /// </summary>
        [Required(ErrorMessage = "Informe o campo Area de Prefeitura")]
        [Display(Name = "Area da Prefeitura")]
        public long AreaPrefeitura { get; set; }

        /// <summary>
        /// Identificado do Distrito onde a feria acontece
        /// </summary>
        [Required(ErrorMessage = "Informe o Código do Distrito")]
        [Display(Name = "Id do distrito")]
        public int DistridoID { get; set; }

        /// <summary>
        /// Referencia ao Distrito da Feira
        /// </summary>
        [Display(Name = "Objeto do distrito")]
        public DistritoRequestDto? Distrito { get; set; }

        /// <summary>
        /// Identificado da Feira
        /// </summary>        
        [Required(ErrorMessage = "Informe o Código do Sub Prefeitura")]
        [Display(Name = "Identificado da SubPrefeitura")]
        public int SubPrefeituraID { get; set; }

        /// <summary>
        /// Referencia da SubPrefeitura da Feira
        /// </summary>
        [Display(Name = "Objeto da SubPrefeitura")]
        public SubPrefeituraRequestDto? SubPrefeitura { get; set; }


        /// <summary>
        /// Região 5 onde a feira acontece
        /// </summary>
        [Required(ErrorMessage = "Informe a Região 5")]
        [StringLength(10)]
        [Display(Name = "Identificador da Regiao 5")]
        public string Regiao5 { get; set; }

        /// <summary>
        /// Região 8 onde a feira acontece
        /// </summary>
        [Required(ErrorMessage = "Informe a Região 8")]
        [StringLength(10)]
        [Display(Name = "Identificador da Regiao 8")]
        public string Regiao8 { get; set; }

        /// <summary>
        /// Nome dado a feira que é de conhecimento dos cidadoes
        /// </summary>
        [Required(ErrorMessage = "Informe o Nome da Feira")]
        [StringLength(100)]
        [Display(Name = "Nome Conhecido da Feira")]
        public string Nome { get; set; }
        /// <summary>
        /// Registro que comprova que a feira é regularizada na prefeitura
        /// </summary>
        [Required(ErrorMessage = "Informe o número de Registro da Feira")]
        [StringLength(10)]
        [Display(Name = "Numero de Registro da Feira")]
        public string Registro { get; set; }

        /// <summary>
        /// Endereço físico onde a feira acontece
        /// </summary>
        [Required(ErrorMessage = "Informe o endereço da Feira")]
        [StringLength(255)]
        [Display(Name = "Endereço onde se localiza a feira")]
        public string Logradouro { get; set; }

        /// <summary>
        /// Número do endereço onde a feira acontece
        /// </summary>
        [Required(ErrorMessage = "Informe o número da rua onde é localizado a Feira")]
        [StringLength(20)]
        [Display(Name = "Numero da rua onde a feira se incia")]
        public string Numero { get; set; }

        /// <summary>
        /// Bairro onde a feira acontece
        /// </summary>
        [Required(ErrorMessage = "Informe nome do Bairro onde se localizada a feira")]
        [StringLength(50)]
        [Display(Name = "Bairro onde a feira acontece")]
        public string Bairro { get; set; }

        /// <summary>
        /// Ponto de referencia da feira
        /// </summary>       
        [StringLength(100)]
        [Display(Name = "Ponto de referencia onde a feira acontece")]
        public string Referencia { get; set; }

    }
}
