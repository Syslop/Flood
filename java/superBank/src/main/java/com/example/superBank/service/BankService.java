package com.example.superBank.service;

import com.example.superBank.model.TransferBalance;
import com.example.superBank.repository.BalanceRepository;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

import java.math.BigDecimal;

@Service
@AllArgsConstructor
public class BankService {

    private final BalanceRepository balanceRepository;
    public BigDecimal getBalance(Long accountId) {
        BigDecimal balance = balanceRepository.getBalanceForId(accountId);
        if (balance == null) {
            throw new IllegalAccessException();
        }
        return balance;
    }

    public BigDecimal addMoney(Long to, BigDecimal amout) {
    }

    public void makeTransfer(TransferBalance transferBalance) {
    }
}
