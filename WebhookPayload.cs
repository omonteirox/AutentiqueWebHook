namespace webhookAutentique;

using System;
using System.Collections.Generic;

public class WebhookPayload
{
    public List<Parte> Partes { get; set; }
    public Documento Documento { get; set; }
    public Remetente Remetente { get; set; }
    public Arquivo Arquivo { get; set; }
    public int Organizacao { get; set; }
}

public class Parte
{
    public string Uuid { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime Nascimento { get; set; }
    public string Empresa { get; set; }
    public int Ordem { get; set; }
    public Assinatura Assinatura { get; set; }
    public string Funcao { get; set; }
    public DateTime Created { get; set; }
    public Evento Visualizado { get; set; }
    public Evento Assinado { get; set; }
    public Mail Mail { get; set; }
}

public class Assinatura
{
    public string Formato { get; set; }
    public string Imagem { get; set; }
}

public class Evento
{
    public DateTime Created { get; set; }
    public string Ipv4 { get; set; }
    public Geotrack Geotrack { get; set; }
}

public class Geotrack
{
    public string Country { get; set; }
    public string CountryISO { get; set; }
    public string State { get; set; }
    public string StateISO { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

public class Mail
{
    public DateTime? Sent { get; set; }
    public DateTime? Delivered { get; set; }
}

public class Documento
{
    public string Uuid { get; set; }
    public string Nome { get; set; }
    public bool Rejeitavel { get; set; }
    public bool Ordenavel { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public string Assinatura { get; set; }
    public DateTime Publicado { get; set; }
    public bool Disponivel { get; set; }
}

public class Remetente
{
    public string Nome { get; set; }
    public string Empresa { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime Nascimento { get; set; }
}

public class Arquivo
{
    public string Original { get; set; }
    public string Assinado { get; set; }
}
