﻿using FluentValidation;
using Tuber.Application.Imports.Commands.ImportAdd;

namespace Tuber.Application.Imports.PipelineValidators;

public class ImportAddAddCommandRequestValidator : AbstractValidator<ImportAddCommandRequest>
{
    public ImportAddAddCommandRequestValidator()
    {
        RuleFor(x => x.ImportTemplateId)
            .NotEmpty();

        RuleFor(x => x.BankAccountId)
            .NotEmpty();

        RuleFor(x => x.ImportFileName)
            .NotEmpty();
    }
}