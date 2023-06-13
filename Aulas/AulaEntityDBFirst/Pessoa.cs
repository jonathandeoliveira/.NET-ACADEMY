﻿using System;
using System.Collections.Generic;

namespace AulaEntityDBFirst;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();
}
