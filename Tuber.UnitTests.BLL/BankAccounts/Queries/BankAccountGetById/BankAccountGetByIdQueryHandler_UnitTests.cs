﻿using AutoMapper;
using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccounts;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetById;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.BankAccounts.Queries.BankAccountGetById;
internal class BankAccountGetByIdQueryHandler_UnitTests
{
    private BankAccount[] _bankAccountArray;
    private List<BankAccount> _bankAccountList;
    private IMapper _mapper;

    [SetUp]
    public void SetUp()
    {
        _bankAccountArray = new BankAccount[]
        {
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 Name = "Bank Account 1",
                 UKBankAccount = "12345678",
                 BankId = Guid.NewGuid(),
                 OrderBy = 10,
                 IsDeleted = false
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 Name = "Bank Account 2",
                 UKBankAccount = "12345678",
                 BankId = Guid.NewGuid(),
                 OrderBy = 20,
                 IsDeleted = true
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 Name = "Bank Account 3",
                 UKBankAccount = "12345678",
                 BankId = Guid.NewGuid(),
                 OrderBy = 30,
                 IsDeleted = true
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 Name = "Bank Account 4",
                 UKBankAccount = "12345678",
                 BankId = Guid.NewGuid(),
                 OrderBy = 40,
                 IsDeleted = true
            },
            new BankAccount
            {
                 BankAccountId = Guid.NewGuid(),
                 Name = "Deleted Bank Account",
                 UKBankAccount = "12345678",
                 BankId = Guid.NewGuid(),
                 OrderBy = 99,
                 IsDeleted = false
            }
        };

        _bankAccountList = new List<BankAccount>();

        for (var i = 0; i < _bankAccountArray.Length; i++)
        {
            _bankAccountList.Add(new BankAccount
            {
                BankAccountId = _bankAccountArray[i].BankAccountId,
                Name = _bankAccountArray[i].Name!,
                UKBankAccount = "12345678",
                OrderBy = _bankAccountArray[i].OrderBy
            });
        }
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankAccountProfile>());
        _mapper = new Mapper(config);


    }

    [Test, Parallelizable]
    public void GetBankAccountByIdQueryHandler_ExistingBankAccount_ReturnsValidPayload()
    {
        var mockBankAccountRetrievalService = new Mock<IBankAccountRetrievalService>();
        var firstRecord = _bankAccountArray[0];

        mockBankAccountRetrievalService.Setup(x => x.GetById(It.Is<Guid>(g => g == firstRecord.BankAccountId)))
            .Returns(new ServiceResult<BankAccount>(payload: firstRecord));

        var sut = new BankAccountGetByIdQueryHandler(mockBankAccountRetrievalService.Object, _mapper);

        var request = new BankAccountGetByIdQueryRequest
        {
            BankAccountId = firstRecord.BankAccountId
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned the correct bank account record
        result.Result.BankAccountId.Should().Be(firstRecord.BankAccountId);
        result.Result.Name.Should().Be(firstRecord.Name);
        result.Result.OrderBy.Should().Be(firstRecord.OrderBy);

        //  Returned no exceptions
        result.Result.HasExceptions.Should().BeFalse();
        result.Result.Exceptions.Count.Should().Be(0);
    }

    [Test, Parallelizable]
    public void GetBankAccountByIdQueryHandler_MissingBankAccount_ReturnsNullPayloadWithException()
    {
        var mockBankAccountRetrievalService = new Mock<IBankAccountRetrievalService>();
        var badId = Guid.NewGuid();

        mockBankAccountRetrievalService.Setup(x => x.GetById(It.Is<Guid>(x => x == badId)))
            .Returns(new ServiceResult<BankAccount>(
                payload: new BankAccount(),
                exception: new BankAccountDoesNotExistException(badId)));

        var sut = new BankAccountGetByIdQueryHandler(mockBankAccountRetrievalService.Object, _mapper);

        var request = new BankAccountGetByIdQueryRequest
        {
            BankAccountId = badId
        };

        var result = sut.Handle(request, new CancellationToken());

        //  Returned a null bank account record
        result.Result.BankAccountId.Should().Be(Guid.Empty);
        result.Result.Name.Should().Be("");
        result.Result.UKBankAccount.Should().Be("");
        result.Result.OrderBy.Should().Be(int.MaxValue);
        result.Result.BankId.Should().Be(Guid.Empty);

        //  Returned one exception
        result.Result.HasExceptions.Should().BeTrue();
        result.Result.Exceptions.Count.Should().Be(1);
        result.Result.Exceptions.First().Should().BeOfType(typeof(BankAccountDoesNotExistException));
    }
}