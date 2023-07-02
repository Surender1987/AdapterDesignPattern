# Adapter design pattern 
Adapter design pattern is a structural design pattern which enables two objects with incompatible interfaces works together. It converts interface of one object to another objects interface. The main components for adapter design patterns are
1. **Target** It defines the interface that client expect to interact
2. **Adapter** Adapter is a class that convert interface client expecting to be interact to interface adaptee need to work
3. **Adaptee** Adaptee is the legacy class which has interface that incompatible with client's interface

This design pattern helps when we have legacy application or code from other teams that we can not modify.

## Implementation of adapter design pattern 
Suppose we are working in an e-commerce plateform and we need to process payements using multiple payment gateways like PayPal and Stripe. Each payment gateway has its own interface, to provide a unified interface we can use adapter design pattern
