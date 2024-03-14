FROM debian:stable-slim

RUN apt-get update && apt-get install curl -y \
    && curl -sSL https://rover.apollo.dev/nix/latest | sh

ENV PATH="/root/.rover/bin:$PATH"

ENTRYPOINT ["rover"]
