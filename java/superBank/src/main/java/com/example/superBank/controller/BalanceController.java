package com.example.superBank.controller;

import com.example.superBank.model.TransferBalance;
import org.springframework.web.bind.annotation.*;

import java.math.BigDecimal;

@RestController("/balance")
public class BalanceController {

    @GetMapping("/{accountId}")
    public BigDecimal getBalance(@PathVariable Long accountId) {

    }

    @PostMapping("/add")
    public BigDecimal getBalance(@RequestBody TransferBalance amount) {

    }

    @PostMapping("/transfer")
    public BigDecimal transfer(@PathVariable Long accountId,
                                 @RequestBody BigDecimal amount) {

    }
}
