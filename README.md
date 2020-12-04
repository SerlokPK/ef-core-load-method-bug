# ef-core-load-method-bug
Reproduction of an ef core bug with using load method.

When we have complex include paths (multiple references to another entities) `Include` method is applying `HasQueryFilter`, but `Load` method doesn't

There is 2 endpoints (use swagger), include endpoint will return 2 resources (because filter is ignoring soft deleted users), load endpoint will return 5 resources
