#import <Foundation/Foundation.h>

typedef struct {
    const char *productIdentifier;
    const char *price;
    const char *currency;
    const char *transactionId;
    const char *additionalParams;
    int type;
} InAppPurchaseParams;
