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
            throw new IllegalArgumentException();
        }
        return balance;
    }

    public BigDecimal addMoney(Long to, BigDecimal amount) {
        BigDecimal currentBalance = balanceRepository.getBalanceForId(to);
        if (currentBalance == null) {
            balanceRepository.save(to, amount);
            return amount;
        } else {
            BigDecimal updateBalance = currentBalance.add(amount);
            balanceRepository.save(to, updateBalance);
            return updateBalance;
        }
    }

    public void makeTransfer(TransferBalance transferBalance) {
        BigDecimal fromBalance = balanceRepository.getBalanceForId(transferBalance.getFrom());
        BigDecimal toBalance = balanceRepository.getBalanceForId(transferBalance.getTo());
        if (fromBalance == null || toBalance == null) {
            throw new IllegalArgumentException("User not found");
        }
        if (transferBalance.getAmount().compareTo(fromBalance) > 0) {
            throw new IllegalArgumentException("The amount on the account is not enough for the transfer.");
        }
        BigDecimal updatedFromBalance = fromBalance.subtract(transferBalance.getAmount());
        BigDecimal updatedToBalance = toBalance.add(transferBalance.getAmount());

        balanceRepository.save(transferBalance.getFrom(), updatedFromBalance);
        balanceRepository.save(transferBalance.getTo(), updatedToBalance);
    }
}