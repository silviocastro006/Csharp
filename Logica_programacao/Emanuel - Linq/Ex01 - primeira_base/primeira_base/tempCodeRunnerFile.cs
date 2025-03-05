var maiorSalariosMedios = funcionarios
                            .GroupBy(x => x.Departamento)
                            .Select(g => new {
                                departamento = g.Key,
                                salario = g.Average(f => f.Salario)
                            })
                            .OrderByDescending(x => x.salario)
                            .Take(3)
                            .ToList();